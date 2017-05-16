namespace Spielereien
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelQuelle = new System.Windows.Forms.Label();
            this.labelZiel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Einblenden = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kopieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Beenden";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelQuelle
            // 
            this.labelQuelle.AutoSize = true;
            this.labelQuelle.Location = new System.Drawing.Point(9, 9);
            this.labelQuelle.Name = "labelQuelle";
            this.labelQuelle.Size = new System.Drawing.Size(49, 17);
            this.labelQuelle.TabIndex = 2;
            this.labelQuelle.Text = "Quelle";
            this.labelQuelle.Click += new System.EventHandler(this.label1_Click);
            this.labelQuelle.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // labelZiel
            // 
            this.labelZiel.AutoSize = true;
            this.labelZiel.Location = new System.Drawing.Point(375, 9);
            this.labelZiel.Name = "labelZiel";
            this.labelZiel.Size = new System.Drawing.Size(31, 17);
            this.labelZiel.TabIndex = 3;
            this.labelZiel.Text = "Ziel";
            this.labelZiel.Click += new System.EventHandler(this.labelZiel_Click);
            this.labelZiel.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Test1",
            "Test2",
            "Test3",
            "Test4",
            "Test5",
            "Test6",
            "Test7"});
            this.comboBox1.Location = new System.Drawing.Point(12, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Andere1",
            "Andere2",
            "Andere3",
            "Andere4",
            "Andere5"});
            this.listBox1.Location = new System.Drawing.Point(344, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(136, 132);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // Einblenden
            // 
            this.Einblenden.AutoSize = true;
            this.Einblenden.Checked = true;
            this.Einblenden.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Einblenden.Location = new System.Drawing.Point(12, 207);
            this.Einblenden.Name = "Einblenden";
            this.Einblenden.Size = new System.Drawing.Size(101, 21);
            this.Einblenden.TabIndex = 6;
            this.Einblenden.Text = "Einblenden";
            this.Einblenden.UseVisualStyleBackColor = true;
            this.Einblenden.CheckedChanged += new System.EventHandler(this.Einblenden_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 294);
            this.Controls.Add(this.Einblenden);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelZiel);
            this.Controls.Add(this.labelQuelle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Spielereien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelQuelle;
        private System.Windows.Forms.Label labelZiel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox Einblenden;
    }
}

