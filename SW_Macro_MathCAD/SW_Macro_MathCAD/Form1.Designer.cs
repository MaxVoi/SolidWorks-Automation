namespace SW_Macro_MathCAD
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
            this.b_create = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_6 = new System.Windows.Forms.Label();
            this.tb_a0x = new System.Windows.Forms.TextBox();
            this.tb_a0y = new System.Windows.Forms.TextBox();
            this.tb_lh = new System.Windows.Forms.TextBox();
            this.tb_rg = new System.Windows.Forms.TextBox();
            this.tb_pmax = new System.Windows.Forms.TextBox();
            this.tb_psimax = new System.Windows.Forms.TextBox();
            this.b_createWithSpline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_create
            // 
            this.b_create.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b_create.Location = new System.Drawing.Point(160, 309);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(200, 50);
            this.b_create.TabIndex = 0;
            this.b_create.Text = "Kurve aus Koordinaten generieren";
            this.b_create.UseVisualStyleBackColor = false;
            this.b_create.Click += new System.EventHandler(this.b_create_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(169, 76);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(30, 17);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "a0x";
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(169, 109);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(31, 17);
            this.label_2.TabIndex = 2;
            this.label_2.Text = "a0y";
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(169, 142);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(19, 17);
            this.label_3.TabIndex = 3;
            this.label_3.Text = "lh";
            // 
            // label_4
            // 
            this.label_4.AutoSize = true;
            this.label_4.Location = new System.Drawing.Point(169, 175);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(21, 17);
            this.label_4.TabIndex = 4;
            this.label_4.Text = "rg";
            // 
            // label_5
            // 
            this.label_5.AutoSize = true;
            this.label_5.Location = new System.Drawing.Point(169, 208);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(42, 17);
            this.label_5.TabIndex = 5;
            this.label_5.Text = "PMax";
            // 
            // label_6
            // 
            this.label_6.AutoSize = true;
            this.label_6.Location = new System.Drawing.Point(169, 241);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(52, 17);
            this.label_6.TabIndex = 6;
            this.label_6.Text = "PsiMax";
            // 
            // tb_a0x
            // 
            this.tb_a0x.Location = new System.Drawing.Point(237, 73);
            this.tb_a0x.Name = "tb_a0x";
            this.tb_a0x.Size = new System.Drawing.Size(100, 22);
            this.tb_a0x.TabIndex = 7;
            // 
            // tb_a0y
            // 
            this.tb_a0y.Location = new System.Drawing.Point(237, 106);
            this.tb_a0y.Name = "tb_a0y";
            this.tb_a0y.Size = new System.Drawing.Size(100, 22);
            this.tb_a0y.TabIndex = 8;
            // 
            // tb_lh
            // 
            this.tb_lh.Location = new System.Drawing.Point(237, 139);
            this.tb_lh.Name = "tb_lh";
            this.tb_lh.Size = new System.Drawing.Size(100, 22);
            this.tb_lh.TabIndex = 9;
            // 
            // tb_rg
            // 
            this.tb_rg.Location = new System.Drawing.Point(237, 172);
            this.tb_rg.Name = "tb_rg";
            this.tb_rg.Size = new System.Drawing.Size(100, 22);
            this.tb_rg.TabIndex = 10;
            // 
            // tb_pmax
            // 
            this.tb_pmax.Location = new System.Drawing.Point(237, 205);
            this.tb_pmax.Name = "tb_pmax";
            this.tb_pmax.Size = new System.Drawing.Size(100, 22);
            this.tb_pmax.TabIndex = 11;
            // 
            // tb_psimax
            // 
            this.tb_psimax.Location = new System.Drawing.Point(237, 238);
            this.tb_psimax.Name = "tb_psimax";
            this.tb_psimax.Size = new System.Drawing.Size(100, 22);
            this.tb_psimax.TabIndex = 12;
            // 
            // b_createWithSpline
            // 
            this.b_createWithSpline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b_createWithSpline.Location = new System.Drawing.Point(160, 389);
            this.b_createWithSpline.Name = "b_createWithSpline";
            this.b_createWithSpline.Size = new System.Drawing.Size(200, 50);
            this.b_createWithSpline.TabIndex = 13;
            this.b_createWithSpline.Text = "Kurve aus Koordinaten generieren";
            this.b_createWithSpline.UseVisualStyleBackColor = false;
            this.b_createWithSpline.Click += new System.EventHandler(this.b_createWithSpline_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.b_createWithSpline);
            this.Controls.Add(this.tb_psimax);
            this.Controls.Add(this.tb_pmax);
            this.Controls.Add(this.tb_rg);
            this.Controls.Add(this.tb_lh);
            this.Controls.Add(this.tb_a0y);
            this.Controls.Add(this.tb_a0x);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.b_create);
            this.Name = "Form1";
            this.Text = "Matchcad Kurve";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_create;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.TextBox tb_a0x;
        private System.Windows.Forms.TextBox tb_a0y;
        private System.Windows.Forms.TextBox tb_lh;
        private System.Windows.Forms.TextBox tb_rg;
        private System.Windows.Forms.TextBox tb_pmax;
        private System.Windows.Forms.TextBox tb_psimax;
        private System.Windows.Forms.Button b_createWithSpline;
    }
}

