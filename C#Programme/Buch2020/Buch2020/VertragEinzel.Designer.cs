namespace Buch2020
{
    partial class VertragEinzel
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
            System.Windows.Forms.Label vNummerLabel;
            System.Windows.Forms.Label gueltigAbLabel;
            System.Windows.Forms.Label gueltigBisLabel;
            System.Windows.Forms.Label kNummerLabel;
            System.Windows.Forms.Label mNummerLabel;
            this.buch2020DataSet = new Buch2020.Buch2020DataSet();
            this.vertragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertragTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.VertragTableAdapter();
            this.tableAdapterManager = new Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager();
            this.kundeTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.KundeTableAdapter();
            this.mediumTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.MediumTableAdapter();
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vNummerTextBox = new System.Windows.Forms.TextBox();
            this.gueltigAbDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gueltigBisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kNummerComboBox = new System.Windows.Forms.ComboBox();
            this.kundeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mNummerComboBox = new System.Windows.Forms.ComboBox();
            this.mediumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kundeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSpeichern = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            vNummerLabel = new System.Windows.Forms.Label();
            gueltigAbLabel = new System.Windows.Forms.Label();
            gueltigBisLabel = new System.Windows.Forms.Label();
            kNummerLabel = new System.Windows.Forms.Label();
            mNummerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vNummerLabel
            // 
            vNummerLabel.AutoSize = true;
            vNummerLabel.Location = new System.Drawing.Point(16, 27);
            vNummerLabel.Name = "vNummerLabel";
            vNummerLabel.Size = new System.Drawing.Size(117, 17);
            vNummerLabel.TabIndex = 1;
            vNummerLabel.Text = "Vertragsnummer:";
            // 
            // gueltigAbLabel
            // 
            gueltigAbLabel.AutoSize = true;
            gueltigAbLabel.Location = new System.Drawing.Point(16, 64);
            gueltigAbLabel.Name = "gueltigAbLabel";
            gueltigAbLabel.Size = new System.Drawing.Size(97, 17);
            gueltigAbLabel.TabIndex = 3;
            gueltigAbLabel.Text = "Ausleihdatum:";
            // 
            // gueltigBisLabel
            // 
            gueltigBisLabel.AutoSize = true;
            gueltigBisLabel.Location = new System.Drawing.Point(16, 96);
            gueltigBisLabel.Name = "gueltigBisLabel";
            gueltigBisLabel.Size = new System.Drawing.Size(123, 17);
            gueltigBisLabel.TabIndex = 5;
            gueltigBisLabel.Text = "Rueckgabedatum:";
            // 
            // kNummerLabel
            // 
            kNummerLabel.AutoSize = true;
            kNummerLabel.Location = new System.Drawing.Point(16, 132);
            kNummerLabel.Name = "kNummerLabel";
            kNummerLabel.Size = new System.Drawing.Size(53, 17);
            kNummerLabel.TabIndex = 7;
            kNummerLabel.Text = "Kunde:";
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(16, 165);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(61, 17);
            mNummerLabel.TabIndex = 9;
            mNummerLabel.Text = "Medium:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "Buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vertragBindingSource
            // 
            this.vertragBindingSource.DataMember = "Vertrag";
            this.vertragBindingSource.DataSource = this.buch2020DataSet;
            // 
            // vertragTableAdapter
            // 
            this.vertragTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = this.kundeTableAdapter;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = this.vertragTableAdapter;
            // 
            // kundeTableAdapter
            // 
            this.kundeTableAdapter.ClearBeforeFill = true;
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // kundeBindingSource
            // 
            this.kundeBindingSource.DataMember = "Kunde";
            this.kundeBindingSource.DataSource = this.buch2020DataSet;
            // 
            // kundeBindingSource1
            // 
            this.kundeBindingSource1.DataMember = "Kunde";
            this.kundeBindingSource1.DataSource = this.buch2020DataSet;
            // 
            // vNummerTextBox
            // 
            this.vNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vertragBindingSource, "vNummer", true));
            this.vNummerTextBox.Enabled = false;
            this.vNummerTextBox.Location = new System.Drawing.Point(139, 22);
            this.vNummerTextBox.Name = "vNummerTextBox";
            this.vNummerTextBox.Size = new System.Drawing.Size(260, 22);
            this.vNummerTextBox.TabIndex = 2;
            // 
            // gueltigAbDateTimePicker
            // 
            this.gueltigAbDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vertragBindingSource, "gueltigAb", true));
            this.gueltigAbDateTimePicker.Location = new System.Drawing.Point(139, 59);
            this.gueltigAbDateTimePicker.Name = "gueltigAbDateTimePicker";
            this.gueltigAbDateTimePicker.Size = new System.Drawing.Size(260, 22);
            this.gueltigAbDateTimePicker.TabIndex = 4;
            // 
            // gueltigBisDateTimePicker
            // 
            this.gueltigBisDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vertragBindingSource, "gueltigBis", true));
            this.gueltigBisDateTimePicker.Location = new System.Drawing.Point(139, 91);
            this.gueltigBisDateTimePicker.Name = "gueltigBisDateTimePicker";
            this.gueltigBisDateTimePicker.Size = new System.Drawing.Size(260, 22);
            this.gueltigBisDateTimePicker.TabIndex = 6;
            // 
            // kNummerComboBox
            // 
            this.kNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vertragBindingSource, "kNummer", true));
            this.kNummerComboBox.DataSource = this.kundeBindingSource3;
            this.kNummerComboBox.DisplayMember = "kName";
            this.kNummerComboBox.FormattingEnabled = true;
            this.kNummerComboBox.Location = new System.Drawing.Point(139, 129);
            this.kNummerComboBox.Name = "kNummerComboBox";
            this.kNummerComboBox.Size = new System.Drawing.Size(260, 24);
            this.kNummerComboBox.TabIndex = 8;
            this.kNummerComboBox.ValueMember = "kNummer";
            // 
            // kundeBindingSource3
            // 
            this.kundeBindingSource3.DataMember = "Kunde";
            this.kundeBindingSource3.DataSource = this.buch2020DataSet;
            // 
            // mNummerComboBox
            // 
            this.mNummerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vertragBindingSource, "mNummer", true));
            this.mNummerComboBox.DataSource = this.mediumBindingSource1;
            this.mNummerComboBox.DisplayMember = "titel";
            this.mNummerComboBox.FormattingEnabled = true;
            this.mNummerComboBox.Location = new System.Drawing.Point(139, 162);
            this.mNummerComboBox.Name = "mNummerComboBox";
            this.mNummerComboBox.Size = new System.Drawing.Size(260, 24);
            this.mNummerComboBox.TabIndex = 10;
            this.mNummerComboBox.ValueMember = "mNummer";
            // 
            // mediumBindingSource1
            // 
            this.mediumBindingSource1.DataMember = "Medium";
            this.mediumBindingSource1.DataSource = this.buch2020DataSet;
            // 
            // kundeBindingSource2
            // 
            this.kundeBindingSource2.DataMember = "Kunde";
            this.kundeBindingSource2.DataSource = this.buch2020DataSet;
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            // 
            // buttonSpeichern
            // 
            this.buttonSpeichern.Location = new System.Drawing.Point(241, 229);
            this.buttonSpeichern.Name = "buttonSpeichern";
            this.buttonSpeichern.Size = new System.Drawing.Size(158, 40);
            this.buttonSpeichern.TabIndex = 11;
            this.buttonSpeichern.Text = "Anlegen";
            this.buttonSpeichern.UseVisualStyleBackColor = true;
            this.buttonSpeichern.Click += new System.EventHandler(this.buttonSpeichern_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(415, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(415, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VertragEinzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 281);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSpeichern);
            this.Controls.Add(vNummerLabel);
            this.Controls.Add(this.vNummerTextBox);
            this.Controls.Add(gueltigAbLabel);
            this.Controls.Add(this.gueltigAbDateTimePicker);
            this.Controls.Add(gueltigBisLabel);
            this.Controls.Add(this.gueltigBisDateTimePicker);
            this.Controls.Add(kNummerLabel);
            this.Controls.Add(this.kNummerComboBox);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerComboBox);
            this.Name = "VertragEinzel";
            this.Text = "Neue Ausleihe erfassen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.VertragEinzel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource vertragBindingSource;
        private Buch2020DataSetTableAdapters.VertragTableAdapter vertragTableAdapter;
        private Buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private System.Windows.Forms.BindingSource kundeBindingSource1;
        private Buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private System.Windows.Forms.TextBox vNummerTextBox;
        private System.Windows.Forms.DateTimePicker gueltigAbDateTimePicker;
        private System.Windows.Forms.DateTimePicker gueltigBisDateTimePicker;
        private System.Windows.Forms.ComboBox kNummerComboBox;
        private System.Windows.Forms.BindingSource kundeBindingSource2;
        private System.Windows.Forms.ComboBox mNummerComboBox;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private System.Windows.Forms.BindingSource kundeBindingSource3;
        private System.Windows.Forms.BindingSource mediumBindingSource1;
        private System.Windows.Forms.Button buttonSpeichern;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}