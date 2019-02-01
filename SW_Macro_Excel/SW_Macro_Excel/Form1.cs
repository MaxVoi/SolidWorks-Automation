using System;
using System.Windows.Forms;
using SldWorks;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace SW_Macro_Excel
{
    public partial class Form1 : Form
    {
        SldWorks.SldWorks swApp;
        Excel.Application exlApp;
        Excel.Workbook exlBook;
        Excel.Worksheet exlSheet;

        int index = 2;

        public Form1()
        {
            InitializeComponent();

            try {
                swApp = (SldWorks.SldWorks)Marshal.GetActiveObject("SldWorks.Application");
            }
            catch (Exception) {
                swApp = new SldWorks.SldWorks();
                swApp.Visible = true;
            }
        }

        private void b_analyze_Click(object sender, EventArgs e)
        {
            // Entleeren der ListBox
            lb_output.Items.Clear();

            ModelDoc2 swModel = swApp.ActiveDoc;
            Configuration ACTC = swModel.GetActiveConfiguration();
            Component2 root = ACTC.GetRootComponent();

            // Verbindung zu Excel herstellen
            exlApp = new Microsoft.Office.Interop.Excel.Application();
            exlApp.Visible = true;

            // neues Worksheet anlegen
            exlBook = exlApp.Workbooks.Add();
            exlSheet = exlBook.ActiveSheet;
            
            // Tabbelkopf anlegen
            exlSheet.Cells[1, 1] = "Menge";
            exlSheet.Cells[1, 2] = "Einheit";
            exlSheet.Cells[1, 3] = "Name";
            exlSheet.Cells[1, 4] = "Bemerkung";

            // calling traverse Methode
            traverse(root);
        }

        private void traverse(Component2 comp)
        {
            object[] childrens = comp.GetChildren();
            foreach (Component2 child in childrens) {
                traverse(child);
            }

            ModelDoc2 mdocChild = comp.GetModelDoc2();

            if (mdocChild.GetType() == 1) {
                // Bezeichnung kann über 2 Möglichkeiten erfolgen 
                // Dateiname (mit GetFileName wird nur der Dateiname aus einem Dateipfad extrahiert 
                string entry = System.IO.Path.GetFileName(comp.GetPathName());
                // oder 
                string entry2 = comp.Name2; 
                //entfernen der 2 hinteren Zeichen im String 
                entry2 = entry2.Remove(entry2.Length - 2);

                int Row = 0;
                
                // überprüfen, ob aktueller Eintrag bereits vorhanden ist, wenn ja Zeilen-Index speichern 
                for (int i = 2; i < index; i++) {
                    if ((string)exlSheet.Cells[i, 3].Value2 == entry) {
                        Row = i;
                    }
                }
                // wenn Zeilen Index gesetzt wurde, Wert für Anzahl aus Zeile lesen und um 1 erhöhen 
                // erhöhten Wert in Zelle schreiben 
                if (Row > 0) {
                    double newCount = (double)exlSheet.Cells[Row, 1].Value2 + 1;
                    exlSheet.Cells[Row, 1] = newCount;
                }
                else {
                    // Wenn ZeilenIndex nicht gesetzt wurde, neuen Dateipfad 
                    exlSheet.Cells[index, 1] = 1;
                    exlSheet.Cells[index, 2] = "Stück";
                    exlSheet.Cells[index, 3] = entry;

                    lb_output.Items.Add(entry);

                    index++;
                }
            }
        }
    }
}
