using System;
using System.Windows.Forms;
using SldWorks;
using System.Runtime.InteropServices;

// Ausgangspunkt: SolidWorks gestartet, keine Datei geladen
// MathCAD geöffnet, Datei Kurve.xcmd geladen

namespace SW_Macro_MathCAD
{
    public partial class Form1 : Form
    {
        SldWorks.SldWorks swApp;

        public Form1()
        {
            InitializeComponent();

            try
            {
                swApp = (SldWorks.SldWorks)Marshal.GetActiveObject("SldWorks.Application");

            }
            catch (Exception)
            {
                swApp = new SldWorks.SldWorks();
                swApp.Visible = true;
            }
        }

        // 
        private void b_create_Click(object sender, EventArgs e)
        {
            // Deklarieren der benötigten Variablen
            double a0x, a0y, lh, rg, PMax, PsiMax;

            // Auslesen der eingegebenen Werte im Formular
            if (double.TryParse(label_1.Text, out a0x) == false ||
                double.TryParse(label_2.Text, out a0y) == false ||
                double.TryParse(label_3.Text, out lh) == false ||
                double.TryParse(label_4.Text, out rg) == false ||
                double.TryParse(tb_pmax.Text, out PMax) == false ||
                double.TryParse(label_6.Text, out PsiMax) == false)
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
                return;
            }

            // Erzeugen eines neuen Bauteils
            ModelDoc2 swModel = (ModelDoc2)swApp.NewPart();

            // Herstellen zwischen MatCAD und aktives Arbeitsblatt auslesen
            Matcad.Application mcApp = (Mathcad.Application)Marshal.GetActiveObject("Mathcad.Applicaiton");
            Mathcad.Worksheet mcWks = mcApp.ActiveWorksheet;

            // neuer Sketch in SolidWorks
            swModel.Extension.SelectByID2("Ebene vorne", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.InsertSketch2(true);

            // Setzen der Parameter im MathCAD Arbeitsblatt
            mcWks.SetValue("a0x", a0x);
            mcWks.SetValue("a0y", a0y);
            mcWks.SetValue("lh", lh);
            mcWks.SetValue("rg", rg);
            mcWks.SetValue("pmax", PMax);
            mcWks.SetValue("psimax", PsiMax);

            double xa = 0.0, ya = 0.0;
            double xk, yk;
            Mathcad.NumericValue mcVal;

            // Schleife zur Berechnung der Stützpunkte
            for (int i = 0; i < PMax; i++)
            {
                // Setzten des Parameters für aktuellen Stützpunkt
                mcWks.SetValue("pact", i);
                
                // Auslesen der berechneten Koordinaten aus MathCAD
                mcVal = (Mathcad.NumericValue)mcWks.GetValue("X");
                xk = mcVal.Real;

                mcVal = (Mathcad.NumericValue)mcWks.GetValue("Y");
                yk = mcVal.Real;

                if (i > 0)
                {
                    swModel.CreateLine2(xa / 1000.0, ya / 1000.0, 0, xk /
                    1000.0, yk / 1000.0, 0);
                }
                xa = xk;
                ya = yk;
            }

            // Kreis zeichnen und extrudieren
            swModel.CreateCircleByRadius2(a0x / 1000.0, a0y / 1000.0, 0.0, 3.0 / 1000.0);

            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0,
                0.01, 0, false, false, false, false, 0, 0, false, false, false,
                false, false, false, false, 0, 0, false);
        }

        // 
        private void b_createWithSpline_Click(object sender, EventArgs e)
        {
            double a0x, a0y, lh, rg, PMax, PsiMax;
            
            // Auslesen der eingegebenen Werte im Formular
            if (double.TryParse(tb_a0x.Text, out a0x) == false ||
                double.TryParse(tb_a0y.Text, out a0y) == false ||
                double.TryParse(tb_lh.Text, out lh) == false ||
                double.TryParse(tb_rg.Text, out rg) == false ||
                double.TryParse(tb_pmax.Text, out PMax) == false ||
                double.TryParse(tb_psimax.Text, out PsiMax) == false)
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
                return;
            }

            // Erzeugen eines neuen Bauteils
            ModelDoc2 swModel = (ModelDoc2)swApp.NewPart();

            // Herstellen zwischen MatCAD und aktives Arbeitsblatt auslesen
            Matcad.Application mcApp = (Mathcad.Application)Marshal.GetActiveObject("Mathcad.Applicaiton");
            Mathcad.Worksheet mcWks = mcApp.ActiveWorksheet;

            // neuer Sketch in SolidWorks
            swModel.Extension.SelectByID2("Ebene vorne", "PLANE", 0, 0, 0, false, 0, null, 0);
            swModel.InsertSketch2(true);

            // Setzen der Parameter im MathCAD Arbeitsblatt
            mcWks.SetValue("a0x", a0x);
            mcWks.SetValue("a0y", a0y);
            mcWks.SetValue("lh", lh);
            mcWks.SetValue("rg", rg);
            mcWks.SetValue("psimax", PsiMax);
            mcWks.SetValue("pcnt", PMax);

            double[] PointData = new double[(int)(PMax * 3 + 3)];
            int pIndex = 0;
            double xk, yk;
            Mathcad.NumericValue mcVal;


            // Schleife zur Berechnung der Stützpunkte
            for (int i = 0; i < PMax; i++)
            {
                // Setzten des Parameters für aktuellen Stützpunkt
                mcWks.SetValue("pact", i);

                // Auslesen der berechneten Koordinaten aus MathCAD
                mcVal = (Mathcad.NumericValue)mcWks.GetValue("X");
                xk = mcVal.Real;

                mcVal = (Mathcad.NumericValue)mcWks.GetValue("Y");
                yk = mcVal.Real;

                PointData[pIndex] = xk / 1000.0;
                PointData[pIndex + 1] = yk / 1000.0;
                PointData[pIndex + 2] = 0;
                pIndex = pIndex + 3;
            }

            swModel.CreateSpline(PointData);
            swModel.CreateCircleByRadius2(a0x / 1000.0, a0y / 1000.0, 0.0, 3.0 / 1000.0);

            swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0,
                0.01, 0, false, false, false, false, 0, 0, false, false, false,
                false, false, false, false, 0, 0, false);
        }
    }
}
