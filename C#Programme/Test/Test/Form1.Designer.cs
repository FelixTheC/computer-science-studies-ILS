namespace Test
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
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBerechnen = new System.Windows.Forms.Button();
            this.buttonEnde = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(12, 12);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(100, 22);
            this.textBoxZahl1.TabIndex = 0;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(12, 66);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(100, 22);
            this.textBoxZahl2.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(204, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Addieren";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Location = new System.Drawing.Point(12, 142);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(68, 17);
            this.labelErgebnis.TabIndex = 3;
            this.labelErgebnis.Text = "Ergebnis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // buttonBerechnen
            // 
            this.buttonBerechnen.Location = new System.Drawing.Point(15, 207);
            this.buttonBerechnen.Name = "buttonBerechnen";
            this.buttonBerechnen.Size = new System.Drawing.Size(97, 23);
            this.buttonBerechnen.TabIndex = 5;
            this.buttonBerechnen.Text = "Berechnen";
            this.buttonBerechnen.UseVisualStyleBackColor = true;
            this.buttonBerechnen.Click += new System.EventHandler(this.buttonBerechnen_Click);
            // 
            // buttonEnde
            // 
            this.buttonEnde.Location = new System.Drawing.Point(204, 207);
            this.buttonEnde.Name = "buttonEnde";
            this.buttonEnde.Size = new System.Drawing.Size(75, 23);
            this.buttonEnde.TabIndex = 6;
            this.buttonEnde.Text = "Ende";
            this.buttonEnde.UseVisualStyleBackColor = true;
            this.buttonEnde.Click += new System.EventHandler(this.buttonEnde_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEnde);
            this.Controls.Add(this.buttonBerechnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBerechnen;
        private System.Windows.Forms.Button buttonEnde;
        private System.Windows.Forms.Label label2;


    }
}

