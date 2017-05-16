namespace einfscher_Taschenrechner
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
            this.berechnen = new System.Windows.Forms.Button();
            this.beenden = new System.Windows.Forms.Button();
            this.ergebnis = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxZahl1 = new System.Windows.Forms.TextBox();
            this.BoxZahl2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMultiplikation = new System.Windows.Forms.RadioButton();
            this.radioButtonDivision = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtraktion = new System.Windows.Forms.RadioButton();
            this.radioButtonAddition = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(12, 165);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(91, 23);
            this.berechnen.TabIndex = 4;
            this.berechnen.Text = "Berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(282, 165);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(91, 23);
            this.beenden.TabIndex = 5;
            this.beenden.Text = "Beenden";
            this.beenden.UseVisualStyleBackColor = true;
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // ergebnis
            // 
            this.ergebnis.AutoSize = true;
            this.ergebnis.Location = new System.Drawing.Point(12, 97);
            this.ergebnis.Name = "ergebnis";
            this.ergebnis.Size = new System.Drawing.Size(68, 17);
            this.ergebnis.TabIndex = 2;
            this.ergebnis.Text = "Ergebnis:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // BoxZahl1
            // 
            this.BoxZahl1.Location = new System.Drawing.Point(12, 12);
            this.BoxZahl1.Name = "BoxZahl1";
            this.BoxZahl1.Size = new System.Drawing.Size(100, 22);
            this.BoxZahl1.TabIndex = 1;
            this.BoxZahl1.Text = "0";
            this.BoxZahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BoxZahl1.TextChanged += new System.EventHandler(this.BoxZahl1_TextChanged);
            // 
            // BoxZahl2
            // 
            this.BoxZahl2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BoxZahl2.Location = new System.Drawing.Point(12, 49);
            this.BoxZahl2.Name = "BoxZahl2";
            this.BoxZahl2.Size = new System.Drawing.Size(100, 22);
            this.BoxZahl2.TabIndex = 2;
            this.BoxZahl2.Text = "0";
            this.BoxZahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BoxZahl2.TextChanged += new System.EventHandler(this.BoxZahl2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMultiplikation);
            this.groupBox1.Controls.Add(this.radioButtonDivision);
            this.groupBox1.Controls.Add(this.radioButtonSubtraktion);
            this.groupBox1.Controls.Add(this.radioButtonAddition);
            this.groupBox1.Location = new System.Drawing.Point(173, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rechenoperation";
            // 
            // radioButtonMultiplikation
            // 
            this.radioButtonMultiplikation.AutoSize = true;
            this.radioButtonMultiplikation.Location = new System.Drawing.Point(84, 101);
            this.radioButtonMultiplikation.Name = "radioButtonMultiplikation";
            this.radioButtonMultiplikation.Size = new System.Drawing.Size(110, 21);
            this.radioButtonMultiplikation.TabIndex = 3;
            this.radioButtonMultiplikation.Text = "Multiplikation";
            this.radioButtonMultiplikation.UseVisualStyleBackColor = true;
            // 
            // radioButtonDivision
            // 
            this.radioButtonDivision.AutoSize = true;
            this.radioButtonDivision.Location = new System.Drawing.Point(84, 75);
            this.radioButtonDivision.Name = "radioButtonDivision";
            this.radioButtonDivision.Size = new System.Drawing.Size(78, 21);
            this.radioButtonDivision.TabIndex = 2;
            this.radioButtonDivision.Text = "Division";
            this.radioButtonDivision.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtraktion
            // 
            this.radioButtonSubtraktion.AutoSize = true;
            this.radioButtonSubtraktion.Location = new System.Drawing.Point(84, 48);
            this.radioButtonSubtraktion.Name = "radioButtonSubtraktion";
            this.radioButtonSubtraktion.Size = new System.Drawing.Size(101, 21);
            this.radioButtonSubtraktion.TabIndex = 1;
            this.radioButtonSubtraktion.Text = "Subtraktion";
            this.radioButtonSubtraktion.UseVisualStyleBackColor = true;
            this.radioButtonSubtraktion.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButtonAddition
            // 
            this.radioButtonAddition.AutoSize = true;
            this.radioButtonAddition.Checked = true;
            this.radioButtonAddition.Location = new System.Drawing.Point(84, 21);
            this.radioButtonAddition.Name = "radioButtonAddition";
            this.radioButtonAddition.Size = new System.Drawing.Size(80, 21);
            this.radioButtonAddition.TabIndex = 0;
            this.radioButtonAddition.TabStop = true;
            this.radioButtonAddition.Text = "Addition";
            this.radioButtonAddition.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxZahl2);
            this.Controls.Add(this.BoxZahl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ergebnis);
            this.Controls.Add(this.beenden);
            this.Controls.Add(this.berechnen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "einfacher Taschenrechner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Button beenden;
        private System.Windows.Forms.Label ergebnis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxZahl1;
        private System.Windows.Forms.TextBox BoxZahl2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonSubtraktion;
        private System.Windows.Forms.RadioButton radioButtonAddition;
        private System.Windows.Forms.RadioButton radioButtonMultiplikation;
        private System.Windows.Forms.RadioButton radioButtonDivision;
    }
}

