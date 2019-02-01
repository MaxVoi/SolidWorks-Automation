namespace SW_Macro_Excel
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
            this.b_analyze = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_analyze
            // 
            this.b_analyze.Location = new System.Drawing.Point(160, 40);
            this.b_analyze.Name = "b_analyze";
            this.b_analyze.Size = new System.Drawing.Size(180, 40);
            this.b_analyze.TabIndex = 0;
            this.b_analyze.Text = "Baugruppe analysieren";
            this.b_analyze.UseVisualStyleBackColor = true;
            this.b_analyze.Click += new System.EventHandler(this.b_analyze_Click);
            // 
            // lb_output
            // 
            this.lb_output.FormattingEnabled = true;
            this.lb_output.ItemHeight = 16;
            this.lb_output.Location = new System.Drawing.Point(120, 156);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(250, 356);
            this.lb_output.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Baugruppenstruktur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.b_analyze);
            this.Name = "Form1";
            this.Text = "Baugruppenanalyse mit Excel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_analyze;
        private System.Windows.Forms.ListBox lb_output;
        private System.Windows.Forms.Label label1;
    }
}

