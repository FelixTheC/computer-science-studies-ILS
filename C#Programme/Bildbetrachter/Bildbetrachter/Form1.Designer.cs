namespace Bildbetrachter
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEinzel = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxFenster = new System.Windows.Forms.CheckBox();
            this.checkBoxGröße = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEnde = new System.Windows.Forms.Button();
            this.buttonÖffnen = new System.Windows.Forms.Button();
            this.buttonAnzeigen = new System.Windows.Forms.Button();
            this.tabPageSchau = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAuswahl = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPageEinzel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageSchau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageEinzel);
            this.tabControl1.Controls.Add(this.tabPageSchau);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 360);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Enter += new System.EventHandler(this.buttonAnzeigen_Click);
            // 
            // tabPageEinzel
            // 
            this.tabPageEinzel.Controls.Add(this.textBox1);
            this.tabPageEinzel.Controls.Add(this.checkBoxFenster);
            this.tabPageEinzel.Controls.Add(this.checkBoxGröße);
            this.tabPageEinzel.Controls.Add(this.pictureBox1);
            this.tabPageEinzel.Controls.Add(this.buttonEnde);
            this.tabPageEinzel.Controls.Add(this.buttonÖffnen);
            this.tabPageEinzel.Controls.Add(this.buttonAnzeigen);
            this.tabPageEinzel.Location = new System.Drawing.Point(4, 25);
            this.tabPageEinzel.Name = "tabPageEinzel";
            this.tabPageEinzel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEinzel.Size = new System.Drawing.Size(411, 331);
            this.tabPageEinzel.TabIndex = 0;
            this.tabPageEinzel.Text = "Einzelbild";
            this.tabPageEinzel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(7, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 22);
            this.textBox1.TabIndex = 4;
            // 
            // checkBoxFenster
            // 
            this.checkBoxFenster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxFenster.AutoSize = true;
            this.checkBoxFenster.Location = new System.Drawing.Point(143, 304);
            this.checkBoxFenster.Name = "checkBoxFenster";
            this.checkBoxFenster.Size = new System.Drawing.Size(123, 21);
            this.checkBoxFenster.TabIndex = 5;
            this.checkBoxFenster.Text = "Neues Fenster";
            this.checkBoxFenster.UseVisualStyleBackColor = true;
            this.checkBoxFenster.CheckedChanged += new System.EventHandler(this.checkBoxFenster_CheckedChanged);
            // 
            // checkBoxGröße
            // 
            this.checkBoxGröße.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxGröße.AutoSize = true;
            this.checkBoxGröße.Location = new System.Drawing.Point(6, 304);
            this.checkBoxGröße.Name = "checkBoxGröße";
            this.checkBoxGröße.Size = new System.Drawing.Size(131, 21);
            this.checkBoxGröße.TabIndex = 5;
            this.checkBoxGröße.Text = "Optimale Größe";
            this.checkBoxGröße.UseVisualStyleBackColor = true;
            this.checkBoxGröße.CheckedChanged += new System.EventHandler(this.checkBoxGröße_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonEnde
            // 
            this.buttonEnde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnde.Location = new System.Drawing.Point(330, 65);
            this.buttonEnde.Name = "buttonEnde";
            this.buttonEnde.Size = new System.Drawing.Size(78, 23);
            this.buttonEnde.TabIndex = 3;
            this.buttonEnde.Text = "Beenden";
            this.buttonEnde.UseVisualStyleBackColor = true;
            this.buttonEnde.Click += new System.EventHandler(this.buttonEnde_Click);
            // 
            // buttonÖffnen
            // 
            this.buttonÖffnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonÖffnen.Location = new System.Drawing.Point(330, 35);
            this.buttonÖffnen.Name = "buttonÖffnen";
            this.buttonÖffnen.Size = new System.Drawing.Size(75, 23);
            this.buttonÖffnen.TabIndex = 2;
            this.buttonÖffnen.Text = "Öffnen";
            this.buttonÖffnen.UseVisualStyleBackColor = true;
            this.buttonÖffnen.Click += new System.EventHandler(this.buttonÖffnen_Click);
            // 
            // buttonAnzeigen
            // 
            this.buttonAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnzeigen.Location = new System.Drawing.Point(330, 6);
            this.buttonAnzeigen.Name = "buttonAnzeigen";
            this.buttonAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.buttonAnzeigen.TabIndex = 1;
            this.buttonAnzeigen.Text = "Anzeigen";
            this.buttonAnzeigen.UseVisualStyleBackColor = true;
            this.buttonAnzeigen.Click += new System.EventHandler(this.buttonAnzeigen_Click);
            this.buttonAnzeigen.Enter += new System.EventHandler(this.tabPageEinzel_Enter);
            // 
            // tabPageSchau
            // 
            this.tabPageSchau.Controls.Add(this.numericUpDown1);
            this.tabPageSchau.Controls.Add(this.listBox1);
            this.tabPageSchau.Controls.Add(this.buttonBeenden);
            this.tabPageSchau.Controls.Add(this.buttonStart);
            this.tabPageSchau.Controls.Add(this.buttonAuswahl);
            this.tabPageSchau.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchau.Name = "tabPageSchau";
            this.tabPageSchau.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchau.Size = new System.Drawing.Size(411, 331);
            this.tabPageSchau.TabIndex = 1;
            this.tabPageSchau.Text = "Bilderschau";
            this.tabPageSchau.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(306, 228);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(318, 78);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(87, 23);
            this.buttonBeenden.TabIndex = 4;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Location = new System.Drawing.Point(318, 42);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(87, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Starten";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAuswahl
            // 
            this.buttonAuswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAuswahl.Location = new System.Drawing.Point(318, 6);
            this.buttonAuswahl.Name = "buttonAuswahl";
            this.buttonAuswahl.Size = new System.Drawing.Size(87, 23);
            this.buttonAuswahl.TabIndex = 0;
            this.buttonAuswahl.Text = "Auswählen";
            this.buttonAuswahl.UseVisualStyleBackColor = true;
            this.buttonAuswahl.Click += new System.EventHandler(this.buttonAuswahl_Click);
            this.buttonAuswahl.Enter += new System.EventHandler(this.tabPageSchau_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Grafikdateien|*.bmp;*.gif;*.jpeg;*.png;*.tif;*.wmf;*.jpg";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Grafikdateien|*.bmp;*.gif;*.jpeg;*.png;*.tif;*.wmf;*.jpg";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(318, 114);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(87, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 384);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bildbetrachter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPageEinzel.ResumeLayout(false);
            this.tabPageEinzel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageSchau.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEinzel;
        private System.Windows.Forms.TabPage tabPageSchau;
        private System.Windows.Forms.Button buttonEnde;
        private System.Windows.Forms.Button buttonÖffnen;
        private System.Windows.Forms.Button buttonAnzeigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxFenster;
        private System.Windows.Forms.CheckBox checkBoxGröße;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAuswahl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

