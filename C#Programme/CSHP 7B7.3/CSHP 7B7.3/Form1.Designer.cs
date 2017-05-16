namespace CSHP_7B7._3
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
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonEnde = new System.Windows.Forms.Button();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.LabelAnzeige = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(12, 237);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(100, 23);
            this.buttonBerechnen.TabIndex = 3;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // buttonEnde
            // 
            this.buttonEnde.Location = new System.Drawing.Point(243, 237);
            this.buttonEnde.Name = "buttonEnde";
            this.buttonEnde.Size = new System.Drawing.Size(75, 23);
            this.buttonEnde.TabIndex = 4;
            this.buttonEnde.Text = "Ende";
            this.buttonEnde.UseVisualStyleBackColor = true;
            this.buttonEnde.Click += new System.EventHandler(this.buttonEnde_Click);
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(12, 12);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 22);
            this.textBoxZahl1.TabIndex = 0;
            this.textBoxZahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(12, 57);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 22);
            this.textBoxZahl2.TabIndex = 1;
            this.textBoxZahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Location = new System.Drawing.Point(9, 187);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(68, 17);
            this.labelErgebnis.TabIndex = 4;
            this.labelErgebnis.Text = "Ergebnis:";
            // 
            // LabelAnzeige
            // 
            this.LabelAnzeige.AutoSize = true;
            this.LabelAnzeige.Location = new System.Drawing.Point(73, 187);
            this.LabelAnzeige.Name = "LabelAnzeige";
            this.LabelAnzeige.Size = new System.Drawing.Size(16, 17);
            this.LabelAnzeige.TabIndex = 5;
            this.LabelAnzeige.Text = "0";
            this.LabelAnzeige.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Addieren",
            "Subtrahieren",
            "Multiplizieren",
            "Dividieren"});
            this.comboBox1.Location = new System.Drawing.Point(197, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 272);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.LabelAnzeige);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.buttonEnde);
            this.Controls.Add(this.buttonBerechnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Button buttonEnde;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.Label LabelAnzeige;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

