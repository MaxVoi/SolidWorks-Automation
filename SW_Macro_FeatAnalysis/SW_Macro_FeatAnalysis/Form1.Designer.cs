namespace SW_Macro_FeatAnalysis
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        /// 
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
            this.b_startSLDWorks = new System.Windows.Forms.Button();
            this.b_analyze_Click = new System.Windows.Forms.Button();
            this.l_listBox = new System.Windows.Forms.Label();
            this.lb_output = new System.Windows.Forms.ListBox();
            this.b_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_startSLDWorks
            // 
            this.b_startSLDWorks.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_startSLDWorks.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_startSLDWorks.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_startSLDWorks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_startSLDWorks.Location = new System.Drawing.Point(160, 40);
            this.b_startSLDWorks.Name = "b_startSLDWorks";
            this.b_startSLDWorks.Size = new System.Drawing.Size(180, 40);
            this.b_startSLDWorks.TabIndex = 0;
            this.b_startSLDWorks.Text = "Verbindung mit SW herstellen";
            this.b_startSLDWorks.UseVisualStyleBackColor = false;
            this.b_startSLDWorks.Click += new System.EventHandler(this.b_startSLDWorks_Click);
            // 
            // b_analyze_Click
            // 
            this.b_analyze_Click.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_analyze_Click.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_analyze_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_analyze_Click.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_analyze_Click.Location = new System.Drawing.Point(160, 137);
            this.b_analyze_Click.Name = "b_analyze_Click";
            this.b_analyze_Click.Size = new System.Drawing.Size(180, 40);
            this.b_analyze_Click.TabIndex = 1;
            this.b_analyze_Click.Text = "Analysiere Bauteil";
            this.b_analyze_Click.UseVisualStyleBackColor = false;
            this.b_analyze_Click.Click += new System.EventHandler(this.b_analyze_Click_Click);
            // 
            // l_listBox
            // 
            this.l_listBox.AutoSize = true;
            this.l_listBox.Location = new System.Drawing.Point(38, 160);
            this.l_listBox.Name = "l_listBox";
            this.l_listBox.Size = new System.Drawing.Size(51, 17);
            this.l_listBox.TabIndex = 3;
            this.l_listBox.Text = "Output";
            // 
            // lb_output
            // 
            this.lb_output.FormattingEnabled = true;
            this.lb_output.ItemHeight = 16;
            this.lb_output.Location = new System.Drawing.Point(41, 183);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(400, 356);
            this.lb_output.TabIndex = 4;
            // 
            // b_about
            // 
            this.b_about.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_about.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.b_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_about.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.b_about.Location = new System.Drawing.Point(41, 40);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(90, 40);
            this.b_about.TabIndex = 5;
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
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.l_listBox);
            this.Controls.Add(this.b_analyze_Click);
            this.Controls.Add(this.b_startSLDWorks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Form1";
            this.Text = "Baugruppenanalyse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_startSLDWorks;
        private System.Windows.Forms.Button b_analyze_Click;
        private System.Windows.Forms.Label l_listBox;
        private System.Windows.Forms.ListBox lb_output;
        private System.Windows.Forms.Button b_about;
    }
}

