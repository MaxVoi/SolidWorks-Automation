using System;
using System.Windows.Forms;
using SldWorks;
using System.Runtime.InteropServices;


namespace SW_Macro_Quad
{
    public partial class Form1 : Form
    {
        // laufende SolidWorks Objekt, das laufende Instanz darstellt, muss unter bestimmten Namen aufrufbar sein
        // Dafür Referenz für auf ein SW-Objekt gebraucht
        SldWorks.SldWorks swApp;
        double breite, laenge, hoehe, radius;

        public Form1()
        {
            InitializeComponent();
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ein kleines Makro zum Erstellen von Quadern und Bohrungen in diesen.");
        }

        private void contact_SW_Click(object sender, EventArgs e)
        {
            try
            {
                swApp = (SldWorks.SldWorks)Marshal.GetActiveObject("SldWorks.Application");
            }
            catch (Exception)
            {
                swApp = new SldWorks.SldWorks();
            }
            swApp.Visible = true;

            MessageBox.Show("Verbindung zu SolidWorks hergestellt.");
        }

        private void b_create_Click(object sender, EventArgs e)
        {
            // Abfrage der Eingabe aus allen Textboxen. 
            // TryParse probiert den String in eine double-Variable zu konvertieren. 
            // Liefert true zurück, wenn String konvertiert werden konnte. 
            // Konvertierter Wert wird in Variable kopiert durch das Wort out. 
            if (double.TryParse(tb_breite.Text, out breite) == false ||
                double.TryParse(tb_laenge.Text, out laenge) == false ||
                double.TryParse(tb_hoehe.Text, out hoehe) == false) // ||
                //double.TryParse(tb_radius.Text, out radius) == false)
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
                return;
            }

            // Werte müssen von mm in m konvertiert werden. 
            breite /= 1000.0;
            laenge /= 1000.0;
            hoehe /= 1000.0;
            radius /= 1000.0;

            // Anlegen eines neuen Bauteiles. 
            ModelDoc2 swModel = swApp.NewPart();

            // Ebene oben wird selektiert und eine Skizze wird eingefügt. 
            swModel.Extension.SelectByID("Ebene oben", "PLANE", 0, 0, 0, false, 1, null);
            swModel.InsertSketch2(true);

            // Skizze wird in Feature konvertiert, damit diese benannt werden kann.
            Sketch swSketch = swModel.GetActiveSketch2();
            Feature swFeat = (Feature)swSketch;
            swFeat.Name = "Grundflaeche";

            swModel.SketchRectangle(0, 0, 0, breite, laenge, 0, true);

            Feature swFeat2 = swModel.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, hoehe, 0, false, false, false, false, 0, 0,
            false, false, false, false, true, true, true, 0, 0, true);

            swFeat2.Name = "Quader";

            swModel.SaveAsSilent("C:\\temp\\Quader_L_" + tb_laenge.Text + "_B_" + tb_breite.Text + "_H_" + tb_hoehe.Text + ".SLDPRT", true);
        }

        private void b_cut_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tb_radius.Text, out radius) == false)
            {
                MessageBox.Show("Fehlerhafte Eingabe!");
                return;
            }
            ModelDoc2 swModel = swApp.ActiveDoc;

            swModel.Extension.SelectByID2("", "FACE", 0.5 * breite, hoehe, -0.5 * laenge, false, 1, null, 0);

            swModel.InsertSketch2(true);

            Sketch swSketch = (Sketch)swModel.GetActiveSketch2();
            swModel.CreateCircleByRadius2(0.5 * breite, 0.5 * laenge, 0, radius);
            swModel.FeatureManager.FeatureCut3(true, false, false, 1, 1, 0.0, 0.0, false, false, false, false, 0, 0, false,
                false, false, false, false, true, true, false, false, false, 0, 0.0, false);

            swModel.SaveAsSilent("C:\\temp\\Quader_L_" + tb_laenge.Text + "_B_" +
            tb_breite.Text + "_H_" + tb_hoehe.Text + "_cut_R_" + tb_radius.Text + ".SLDPRT", true);
        }

    }
}
