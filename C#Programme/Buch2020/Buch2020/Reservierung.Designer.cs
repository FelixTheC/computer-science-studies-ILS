namespace Buch2020
{
    partial class Reservierung
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
            System.Windows.Forms.Label rNummerLabel;
            System.Windows.Forms.Label gueltigBisLabel;
            System.Windows.Forms.Label kNummerLabel;
            System.Windows.Forms.Label mNummerLabel;
            this.buch2020DataSet = new Buch2020.Buch2020DataSet();
            this.reservierungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservierungTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.ReservierungTableAdapter();
            this.tableAdapterManager = new Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager();
            this.kundeTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.KundeTableAdapter();
            this.mediumTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.MediumTableAdapter();
            this.rNummerTextBox = new System.Windows.Forms.TextBox();
            this.gueltigBisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kNummerComboBox = new System.Windows.Forms.ComboBox();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mNummerComboBox = new System.Windows.Forms.ComboBox();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.mediumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            rNummerLabel = new System.Windows.Forms.Label();
            gueltigBisLabel = new System.Windows.Forms.Label();
            kNummerLabel = new System.Windows.Forms.Label();
            mNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rNummerLabel
            // 
            rNummerLabel.AutoSize = true;
            rNummerLabel.Location = new System.Drawing.Point(12, 17);
            rNummerLabel.Name = "rNummerLabel";
            rNummerLabel.Size = new System.Drawing.Size(151, 17);
            rNummerLabel.TabIndex = 1;
            rNummerLabel.Text = "Reservierungsnummer";
            // 
            // gueltigBisLabel
            // 
            gueltigBisLabel.AutoSize = true;
            gueltigBisLabel.Location = new System.Drawing.Point(12, 48);
            gueltigBisLabel.Name = "gueltigBisLabel";
            gueltigBisLabel.Size = new System.Drawing.Size(71, 17);
            gueltigBisLabel.TabIndex = 3;
            gueltigBisLabel.Text = "Gültig bis:";
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(12, 80);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(112, 17);
            kNummerLabel.TabIndex = 5;
            kNummerLabel.Text = "Kundennummer:";
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(12, 108);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(109, 17);
            mNummerLabel.TabIndex = 7;
            mNummerLabel.Text = "Mediennummer:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "Buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservierungBindingSource
            // 
            this.reservierungBindingSource.DataMember = "Reservierung";
            this.reservierungBindingSource.DataSource = this.buch2020DataSet;
            // 
            // reservierungTableAdapter
            // 
            this.reservierungTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungTableAdapter = this.reservierungTableAdapter;
            this.tableAdapterManager.UpdateOrder = Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = null;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // rNummerTextBox
            // 
            this.rNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservierungBindingSource, "rNummer", true));
            this.rNummerTextBox.Location = new System.Drawing.Point(182, 12);
            this.rNummerTextBox.Name = "rNummerTextBox";
            this.rNummerTextBox.ReadOnly = true;
            this.rNummerTextBox.Size = new System.Drawing.Size(240, 22);
            this.rNummerTextBox.TabIndex = 2;
            // 
            // gueltigBisDateTimePicker
            // 
            this.gueltigBisDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.reservierungBindingSource, "gueltigBis", true));
            this.gueltigBisDateTimePicker.Location = new System.Drawing.Point(182, 43);
            this.gueltigBisDateTimePicker.Name = "gueltigBisDateTimePicker";
            this.gueltigBisDateTimePicker.Size = new System.Drawing.Size(240, 22);
            this.gueltigBisDateTimePicker.TabIndex = 4;
            // 
            // kNummerComboBox
            // 
            this.kNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservierungBindingSource, "kNummer", true));
            this.kNummerComboBox.DataSource = this.kundeBindingSource;
            this.kNummerComboBox.DisplayMember = "kName";
            this.kNummerComboBox.FormattingEnabled = true;
            this.kNummerComboBox.Location = new System.Drawing.Point(182, 71);
            this.kNummerComboBox.Name = "kNummerComboBox";
            this.kNummerComboBox.Size = new System.Drawing.Size(240, 24);
            this.kNummerComboBox.TabIndex = 8;
            this.kNummerComboBox.ValueMember = "kNummer";
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.buch2020DataSet;
            // 
            // mNummerComboBox
            // 
            this.mNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.reservierungBindingSource, "mNummer", true));
            this.mNummerComboBox.DataSource = this.mediumBindingSource1;
            this.mNummerComboBox.DisplayMember = "titel";
            this.mNummerComboBox.FormattingEnabled = true;
            this.mNummerComboBox.Location = new System.Drawing.Point(182, 101);
            this.mNummerComboBox.Name = "mNummerComboBox";
            this.mNummerComboBox.Size = new System.Drawing.Size(240, 24);
            this.mNummerComboBox.TabIndex = 9;
            this.mNummerComboBox.ValueMember = "mNummer";
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            this.mediumBindingSource.Filter = "ausgeliehen = 1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.Location = new System.Drawing.Point(98, 153);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(102, 23);
            this.buttonUebernehmen.TabIndex = 12;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            this.buttonUebernehmen.Click += new System.EventHandler(this.buttonUebernehmen_Click);
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(360, 153);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(102, 23);
            this.buttonAbbrechen.TabIndex = 13;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // mediumBindingSource1
            // 
            this.mediumBindingSource1.DataMember = "Medium";
            this.mediumBindingSource1.DataSource = this.buch2020DataSet;
            // 
            // Reservierung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 190);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUebernehmen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mNummerComboBox);
            this.Controls.Add(this.kNummerComboBox);
            this.Controls.Add(rNummerLabel);
            this.Controls.Add(this.rNummerTextBox);
            this.Controls.Add(gueltigBisLabel);
            this.Controls.Add(this.gueltigBisDateTimePicker);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(mNummerLabel);
            this.Name = "Reservierung";
            this.Text = "Reservierung";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Reservierung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource reservierungBindingSource;
        private Buch2020DataSetTableAdapters.ReservierungTableAdapter reservierungTableAdapter;
        private Buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox rNummerTextBox;
        private System.Windows.Forms.DateTimePicker gueltigBisDateTimePicker;
        private Buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.ComboBox kNummerComboBox;
        private System.Windows.Forms.ComboBox mNummerComboBox;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private Buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.BindingSource mediumBindingSource1;
    }
}