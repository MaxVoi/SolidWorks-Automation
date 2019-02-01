using System;
using System.Windows.Forms;
using SldWorks;
using SwConst;
using System.Runtime.InteropServices;

namespace SW_Macro_FeatAnalysis
{
    public partial class Form1 : Form
    {
        SldWorks.SldWorks swApp;

        public Form1()
        {
            InitializeComponent();
        }

        // Verbindet mit SolidWorks
        private void b_startSLDWorks_Click(object sender, EventArgs e)
        {
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

        // Durchläuft alle Feature des geladenenen Teils und sucht nach Kreis-Elementen, gibt diese in ListBox aus 
        private void b_analyze_Click_Click(object sender, EventArgs e)
        {
            //Variablen
            ModelDoc2 swModel;
            Feature swFeature, subFeature;
            String FeatureName, FeatureType;
            Sketch swSketch;
            Object[] Segments;
            SketchPoint cPoint;

            // Bereinigen der ListBox
            lb_output.Items.Clear();

            // sldprt breits geöffnent, daher nur auslesen des bereits geöffneten Teils
            swModel = (ModelDoc2)swApp.ActiveDoc;
            swFeature = (Feature)swModel.FirstFeature();

            // Durchlaufen aller Features
            while (swFeature != null)
            {
                // Output des Featurenamen und Typs in ListBox
                lb_output.Items.Add(swFeature.Name + " " + swFeature.GetTypeName());

                // Überprüfen, ob Feature vom Typ Schnitt
                // weiterhin, ob Name "Bohrbild"
                if (swFeature.GetTypeName() == "Cut" && swFeature.Name == "Bohrbild")
                {
                    // Auslesen des ersten Sub-Features
                    subFeature = (Feature)swFeature.GetFirstSubFeature();

                    // Durchlaufen aller Sub-Features
                    while (subFeature != null)
                    {
                        FeatureName = subFeature.Name;
                        FeatureType = subFeature.GetTypeName();

                        // Output des Sub-Feature Name und Typs in ListBox
                        lb_output.Items.Add("\t" + FeatureName + "\t" + FeatureType);

                        // Überprüfen, ob es sich um Skizze handelt (ProfilFeature)
                        if (FeatureType == "ProfileFeature")
                        {
                            // Auslesen des spezifischen Features
                            swSketch = (Sketch)subFeature.GetSpecificFeature2();
                            // Auslesen der Skizzenegmente
                            Segments = (Object[])swSketch.GetSketchSegments();

                            // Durchlaufe alle Sketch-Segmente
                            foreach (SketchSegment sketchSeg in Segments)
                            {
                                // Prüfen, ob aktuelles Sketch-Segment vom Typ swSketchARC
                                if (sketchSeg.GetType() == (int)swSketchSegments_e.swSketchARC)
                                {
                                    // Umwandeln in Skizzenkreis
                                    SketchArc arc = (SketchArc)sketchSeg;
                                    // Auslesen Mittelpunkt 
                                    cPoint = (SketchPoint)arc.GetCenterPoint2();

                                    // Ausgeben in Listbox
                                    lb_output.Items.Add("\tKreis: X = " + cPoint.X + "\tY=" + cPoint.Y + "\tZ=" + cPoint.Z +
                                        "\tR=" + arc.GetRadius());
                                }
                            }
                        }

                        // nächstes Sub-Feature
                        // wenn keines mehr vorhanden, liefert "null" zurück und bricht aus Schleife aus
                        subFeature = (Feature)subFeature.GetNextSubFeature();
                    }
                }
                // nächstes Feature
                swFeature = (Feature)swFeature.GetNextFeature();
            }
        }

        private void b_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kleines Makro, das eine Baugruppe analysiert und alle Feature ausgibt. Außerdem zeigt es die Koordinaten der Bohrungen an. ");
        }
    }
}



