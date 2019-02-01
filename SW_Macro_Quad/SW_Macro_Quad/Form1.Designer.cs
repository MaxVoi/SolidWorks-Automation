namespace SW_Macro_Quad
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.contact_SW = new System.Windows.Forms.Button();
            this.b_create = new System.Windows.Forms.Button();
            this.b_cut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_breite = new System.Windows.Forms.TextBox();
            this.tb_laenge = new System.Windows.Forms.TextBox();
            this.tb_hoehe = new System.Windows.Forms.TextBox();
            this.tb_radius = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contact_SW
            // 
            this.contact_SW.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contact_SW.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.contact_SW.Location = new System.Drawing.Point(160, 30);
            this.contact_SW.Name = "contact_SW";
            this.contact_SW.Size = new System.Drawing.Size(180, 40);
            this.contact_SW.TabIndex = 0;
            this.contact_SW.Text = "Kontaktiere SolidWorks";
            this.contact_SW.UseVisualStyleBackColor = false;
            this.contact_SW.Click += new System.EventHandler(this.contact_SW_Click);
            // 
            // b_create
            // 
            this.b_create.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_create.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_create.Location = new System.Drawing.Point(160, 240);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(180, 40);
            this.b_create.TabIndex = 1;
            this.b_create.Text = "Erstelle Quader";
            this.b_create.UseVisualStyleBackColor = false;
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // b_cut
            // 
            this.b_cut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_cut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_cut.Location = new System.Drawing.Point(160, 383);
            this.b_cut.Name = "b_cut";
            this.b_cut.Size = new System.Drawing.Size(180, 40);
            this.b_cut.TabIndex = 2;
            this.b_cut.Text = "Erstelle zentrierte Bohrung";
            this.b_cut.UseVisualStyleBackColor = false;
            this.b_cut.Click += new System.EventHandler(this.b_cut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Breite (mm)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiefe (mm)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Höhe (mm)";
            // 
            // tb_breite
            // 
            this.tb_breite.Location = new System.Drawing.Point(260, 141);
            this.tb_breite.Name = "tb_breite";
            this.tb_breite.Size = new System.Drawing.Size(80, 22);
            this.tb_breite.TabIndex = 6;
            // 
            // tb_laenge
            // 
            this.tb_laenge.Location = new System.Drawing.Point(260, 174);
            this.tb_laenge.Name = "tb_laenge";
            this.tb_laenge.Size = new System.Drawing.Size(80, 22);
            this.tb_laenge.TabIndex = 7;
            // 
            // tb_hoehe
            // 
            this.tb_hoehe.Location = new System.Drawing.Point(260, 207);
            this.tb_hoehe.Name = "tb_hoehe";
            this.tb_hoehe.Size = new System.Drawing.Size(80, 22);
            this.tb_hoehe.TabIndex = 8;
            // 
            // tb_radius
            // 
            this.tb_radius.Location = new System.Drawing.Point(260, 350);
            this.tb_radius.Name = "tb_radius";
            this.tb_radius.Size = new System.Drawing.Size(80, 22);
            this.tb_radius.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Radius (mm)";
            // 
            // b_about
            // 
            this.b_about.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_about.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_about.Location = new System.Drawing.Point(67, 486);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(90, 40);
            this.b_about.TabIndex = 11;
            this.b_about.Text = "About";
            this.b_about.UseVisualStyleBackColor = false;
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.b_about);
            this.Controls.Add(this.tb_radius);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_hoehe);
            this.Controls.Add(this.tb_laenge);
            this.Controls.Add(this.tb_breite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_cut);
            this.Controls.Add(this.b_create);
            this.Controls.Add(this.contact_SW);
            this.MaximumSize = new System.Drawing.Size(800, 1000);
            this.Name = "Form1";
            this.Text = "Quadererstellung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contact_SW;
        private System.Windows.Forms.Button b_create;
        private System.Windows.Forms.Button b_cut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_breite;
        private System.Windows.Forms.TextBox tb_laenge;
        private System.Windows.Forms.TextBox tb_hoehe;
        private System.Windows.Forms.TextBox tb_radius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_about;
    }
}

