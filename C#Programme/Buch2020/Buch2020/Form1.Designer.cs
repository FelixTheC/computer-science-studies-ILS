namespace Buch2020
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
            this.groupBoxKunden = new System.Windows.Forms.GroupBox();
            this.buttonEinzel = new System.Windows.Forms.Button();
            this.buttonListe = new System.Windows.Forms.Button();
            this.groupBoxMedien = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMedien = new System.Windows.Forms.Button();
            this.buttonVertrag = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxKunden.SuspendLayout();
            this.groupBoxMedien.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKunden
            // 
            this.groupBoxKunden.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxKunden.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxKunden.Controls.Add(this.buttonEinzel);
            this.groupBoxKunden.Controls.Add(this.buttonListe);
            this.groupBoxKunden.Location = new System.Drawing.Point(12, 12);
            this.groupBoxKunden.Name = "groupBoxKunden";
            this.groupBoxKunden.Size = new System.Drawing.Size(201, 184);
            this.groupBoxKunden.TabIndex = 0;
            this.groupBoxKunden.TabStop = false;
            this.groupBoxKunden.Text = "Kunden";
            this.groupBoxKunden.UseWaitCursor = true;
            // 
            // buttonEinzel
            // 
            this.buttonEinzel.Location = new System.Drawing.Point(43, 112);
            this.buttonEinzel.Name = "buttonEinzel";
            this.buttonEinzel.Size = new System.Drawing.Size(102, 54);
            this.buttonEinzel.TabIndex = 1;
            this.buttonEinzel.Text = "Einzelansicht";
            this.buttonEinzel.UseVisualStyleBackColor = true;
            this.buttonEinzel.UseWaitCursor = true;
            this.buttonEinzel.Click += new System.EventHandler(this.buttonEinzel_Click);
            // 
            // buttonListe
            // 
            this.buttonListe.Location = new System.Drawing.Point(43, 33);
            this.buttonListe.Name = "buttonListe";
            this.buttonListe.Size = new System.Drawing.Size(102, 54);
            this.buttonListe.TabIndex = 0;
            this.buttonListe.Text = "Listenansicht";
            this.buttonListe.UseVisualStyleBackColor = true;
            this.buttonListe.UseWaitCursor = true;
            this.buttonListe.Click += new System.EventHandler(this.buttonListe_Click);
            // 
            // groupBoxMedien
            // 
            this.groupBoxMedien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxMedien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxMedien.Controls.Add(this.button1);
            this.groupBoxMedien.Controls.Add(this.buttonMedien);
            this.groupBoxMedien.Location = new System.Drawing.Point(249, 12);
            this.groupBoxMedien.Name = "groupBoxMedien";
            this.groupBoxMedien.Size = new System.Drawing.Size(185, 184);
            this.groupBoxMedien.TabIndex = 1;
            this.groupBoxMedien.TabStop = false;
            this.groupBoxMedien.Text = "Medien";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Medieneinzel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMedien
            // 
            this.buttonMedien.Location = new System.Drawing.Point(46, 33);
            this.buttonMedien.Name = "buttonMedien";
            this.buttonMedien.Size = new System.Drawing.Size(102, 54);
            this.buttonMedien.TabIndex = 0;
            this.buttonMedien.Text = "Medienliste";
            this.buttonMedien.UseVisualStyleBackColor = true;
            this.buttonMedien.Click += new System.EventHandler(this.buttonMedien_Click);
            // 
            // buttonVertrag
            // 
            this.buttonVertrag.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonVertrag.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonVertrag.Location = new System.Drawing.Point(0, 381);
            this.buttonVertrag.Name = "buttonVertrag";
            this.buttonVertrag.Size = new System.Drawing.Size(446, 64);
            this.buttonVertrag.TabIndex = 2;
            this.buttonVertrag.Text = "Vertrag";
            this.buttonVertrag.UseVisualStyleBackColor = true;
            this.buttonVertrag.Click += new System.EventHandler(this.buttonVertrag_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(446, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Reservierung";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(0, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(446, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kundensuche";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 445);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonVertrag);
            this.Controls.Add(this.groupBoxMedien);
            this.Controls.Add(this.groupBoxKunden);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Buch2020";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBoxKunden.ResumeLayout(false);
            this.groupBoxMedien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKunden;
        private System.Windows.Forms.Button buttonListe;
        private System.Windows.Forms.GroupBox groupBoxMedien;
        private System.Windows.Forms.Button buttonEinzel;
        private System.Windows.Forms.Button buttonMedien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVertrag;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

