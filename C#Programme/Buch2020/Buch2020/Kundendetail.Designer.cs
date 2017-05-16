namespace Buch2020
{
    partial class Kundendetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label kNummerLabel;
            System.Windows.Forms.Label kNameLabel;
            System.Windows.Forms.Label vornameLabel;
            System.Windows.Forms.Label strasseLabel;
            System.Windows.Forms.Label postleitzahlLabel;
            System.Windows.Forms.Label ortLabel;
            System.Windows.Forms.Label telefon1Label;
            System.Windows.Forms.Label telefon2Label;
            this.buch2020DataSet = new Buch2020.Buch2020DataSet();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.KundeTableAdapter();
            this.tableAdapterManager = new Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager();
            this.kNummerTextBox = new System.Windows.Forms.TextBox();
            this.kNameTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.postleitzahlTextBox = new System.Windows.Forms.TextBox();
            this.ortTextBox = new System.Windows.Forms.TextBox();
            this.telefon1TextBox = new System.Windows.Forms.TextBox();
            this.telefon2TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            kNummerLabel = new System.Windows.Forms.Label();
            kNameLabel = new System.Windows.Forms.Label();
            vornameLabel = new System.Windows.Forms.Label();
            strasseLabel = new System.Windows.Forms.Label();
            postleitzahlLabel = new System.Windows.Forms.Label();
            ortLabel = new System.Windows.Forms.Label();
            telefon1Label = new System.Windows.Forms.Label();
            telefon2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(12, 40);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(114, 17);
            kNummerLabel.TabIndex = 1;
            kNummerLabel.Text = "KundenNummer:";
            // 
            // kNameLabel
            // 
            kNameLabel.AutoSize = true;
            kNameLabel.Location = new System.Drawing.Point(12, 68);
            kNameLabel.Name = "kNameLabel";
            kNameLabel.Size = new System.Drawing.Size(49, 17);
            kNameLabel.TabIndex = 3;
            kNameLabel.Text = "Name:";
            // 
            // vornameLabel
            // 
            vornameLabel.AutoSize = true;
            vornameLabel.Location = new System.Drawing.Point(12, 96);
            vornameLabel.Name = "vornameLabel";
            vornameLabel.Size = new System.Drawing.Size(69, 17);
            vornameLabel.TabIndex = 5;
            vornameLabel.Text = "Vorname:";
            // 
            // strasseLabel
            // 
            strasseLabel.AutoSize = true;
            strasseLabel.Location = new System.Drawing.Point(12, 124);
            strasseLabel.Name = "strasseLabel";
            strasseLabel.Size = new System.Drawing.Size(60, 17);
            strasseLabel.TabIndex = 7;
            strasseLabel.Text = "Strasse:";
            // 
            // postleitzahlLabel
            // 
            postleitzahlLabel.AutoSize = true;
            postleitzahlLabel.Location = new System.Drawing.Point(12, 152);
            postleitzahlLabel.Name = "postleitzahlLabel";
            postleitzahlLabel.Size = new System.Drawing.Size(84, 17);
            postleitzahlLabel.TabIndex = 9;
            postleitzahlLabel.Text = "Postleitzahl:";
            // 
            // ortLabel
            // 
            ortLabel.AutoSize = true;
            ortLabel.Location = new System.Drawing.Point(12, 180);
            ortLabel.Name = "ortLabel";
            ortLabel.Size = new System.Drawing.Size(32, 17);
            ortLabel.TabIndex = 11;
            ortLabel.Text = "Ort:";
            // 
            // telefon1Label
            // 
            telefon1Label.AutoSize = true;
            telefon1Label.Location = new System.Drawing.Point(12, 208);
            telefon1Label.Name = "telefon1Label";
            telefon1Label.Size = new System.Drawing.Size(60, 17);
            telefon1Label.TabIndex = 13;
            telefon1Label.Text = "Telefon:";
            // 
            // telefon2Label
            // 
            telefon2Label.AutoSize = true;
            telefon2Label.Location = new System.Drawing.Point(12, 236);
            telefon2Label.Name = "telefon2Label";
            telefon2Label.Size = new System.Drawing.Size(45, 17);
            telefon2Label.TabIndex = 15;
            telefon2Label.Text = "Mobil:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "Buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.buch2020DataSet;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = null;
            this.tableAdapterManager.ReservierungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = null;
            // 
            // kNummerTextBox
            // 
            this.kNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "kNummer", true));
            this.kNummerTextBox.Location = new System.Drawing.Point(141, 40);
            this.kNummerTextBox.Name = "kNummerTextBox";
            this.kNummerTextBox.ReadOnly = true;
            this.kNummerTextBox.Size = new System.Drawing.Size(211, 22);
            this.kNummerTextBox.TabIndex = 2;
            this.kNummerTextBox.TextChanged += new System.EventHandler(this.kNummerTextBox_TextChanged);
            // 
            // kNameTextBox
            // 
            this.kNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "kName", true));
            this.kNameTextBox.Location = new System.Drawing.Point(141, 68);
            this.kNameTextBox.Name = "kNameTextBox";
            this.kNameTextBox.ReadOnly = true;
            this.kNameTextBox.Size = new System.Drawing.Size(211, 22);
            this.kNameTextBox.TabIndex = 4;
            this.kNameTextBox.TextChanged += new System.EventHandler(this.kNameTextBox_TextChanged);
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "vorname", true));
            this.vornameTextBox.Location = new System.Drawing.Point(141, 96);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.ReadOnly = true;
            this.vornameTextBox.Size = new System.Drawing.Size(211, 22);
            this.vornameTextBox.TabIndex = 6;
            this.vornameTextBox.TextChanged += new System.EventHandler(this.vornameTextBox_TextChanged);
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "strasse", true));
            this.strasseTextBox.Location = new System.Drawing.Point(141, 124);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.ReadOnly = true;
            this.strasseTextBox.Size = new System.Drawing.Size(211, 22);
            this.strasseTextBox.TabIndex = 8;
            // 
            // postleitzahlTextBox
            // 
            this.postleitzahlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "postleitzahl", true));
            this.postleitzahlTextBox.Location = new System.Drawing.Point(141, 152);
            this.postleitzahlTextBox.Name = "postleitzahlTextBox";
            this.postleitzahlTextBox.ReadOnly = true;
            this.postleitzahlTextBox.Size = new System.Drawing.Size(211, 22);
            this.postleitzahlTextBox.TabIndex = 10;
            // 
            // ortTextBox
            // 
            this.ortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "ort", true));
            this.ortTextBox.Location = new System.Drawing.Point(141, 180);
            this.ortTextBox.Name = "ortTextBox";
            this.ortTextBox.ReadOnly = true;
            this.ortTextBox.Size = new System.Drawing.Size(211, 22);
            this.ortTextBox.TabIndex = 12;
            // 
            // telefon1TextBox
            // 
            this.telefon1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "telefon1", true));
            this.telefon1TextBox.Location = new System.Drawing.Point(141, 208);
            this.telefon1TextBox.Name = "telefon1TextBox";
            this.telefon1TextBox.ReadOnly = true;
            this.telefon1TextBox.Size = new System.Drawing.Size(211, 22);
            this.telefon1TextBox.TabIndex = 14;
            // 
            // telefon2TextBox
            // 
            this.telefon2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kundeBindingSource, "telefon2", true));
            this.telefon2TextBox.Location = new System.Drawing.Point(141, 236);
            this.telefon2TextBox.Name = "telefon2TextBox";
            this.telefon2TextBox.ReadOnly = true;
            this.telefon2TextBox.Size = new System.Drawing.Size(211, 22);
            this.telefon2TextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "Verlassen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kundendetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(this.kNummerTextBox);
            this.Controls.Add(kNameLabel);
            this.Controls.Add(this.kNameTextBox);
            this.Controls.Add(vornameLabel);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(strasseLabel);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(postleitzahlLabel);
            this.Controls.Add(this.postleitzahlTextBox);
            this.Controls.Add(ortLabel);
            this.Controls.Add(this.ortTextBox);
            this.Controls.Add(telefon1Label);
            this.Controls.Add(this.telefon1TextBox);
            this.Controls.Add(telefon2Label);
            this.Controls.Add(this.telefon2TextBox);
            this.Name = "Kundendetail";
            this.Text = "Detailanzeige Kunden";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Kundendetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private Buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private Buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox kNummerTextBox;
        private System.Windows.Forms.TextBox kNameTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox postleitzahlTextBox;
        private System.Windows.Forms.TextBox ortTextBox;
        private System.Windows.Forms.TextBox telefon1TextBox;
        private System.Windows.Forms.TextBox telefon2TextBox;
        private System.Windows.Forms.Button button1;
    }
}