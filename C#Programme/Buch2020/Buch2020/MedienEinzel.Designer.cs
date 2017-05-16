namespace Buch2020
{
    partial class MedienEinzel
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
            System.Windows.Forms.Label mNummerLabel;
            System.Windows.Forms.Label titelLabel;
            System.Windows.Forms.Label typLabel;
            System.Windows.Forms.Label standortLabel;
            System.Windows.Forms.Label ausgeliehenLabel;
            System.Windows.Forms.Label bestandLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedienEinzel));
            this.buch2020DataSet = new Buch2020.Buch2020DataSet();
            this.mediumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediumTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.MediumTableAdapter();
            this.tableAdapterManager = new Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager();
            this.mNummerTextBox = new System.Windows.Forms.TextBox();
            this.titelTextBox = new System.Windows.Forms.TextBox();
            this.typTextBox = new System.Windows.Forms.TextBox();
            this.standortTextBox = new System.Windows.Forms.TextBox();
            this.ausgeliehenCheckBox = new System.Windows.Forms.CheckBox();
            this.bestandCheckBox = new System.Windows.Forms.CheckBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.mediumBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mediumBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.kundeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kundeTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.KundeTableAdapter();
            this.vertragBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertragTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.VertragTableAdapter();
            this.reservierungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservierungTableAdapter = new Buch2020.Buch2020DataSetTableAdapters.ReservierungTableAdapter();
            mNummerLabel = new System.Windows.Forms.Label();
            titelLabel = new System.Windows.Forms.Label();
            typLabel = new System.Windows.Forms.Label();
            standortLabel = new System.Windows.Forms.Label();
            ausgeliehenLabel = new System.Windows.Forms.Label();
            bestandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingNavigator)).BeginInit();
            this.mediumBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mNummerLabel
            // 
            mNummerLabel.AutoSize = true;
            mNummerLabel.Location = new System.Drawing.Point(12, 42);
            mNummerLabel.Name = "mNummerLabel";
            mNummerLabel.Size = new System.Drawing.Size(109, 17);
            mNummerLabel.TabIndex = 1;
            mNummerLabel.Text = "Mediennummer:";
            // 
            // titelLabel
            // 
            titelLabel.AutoSize = true;
            titelLabel.Location = new System.Drawing.Point(12, 70);
            titelLabel.Name = "titelLabel";
            titelLabel.Size = new System.Drawing.Size(39, 17);
            titelLabel.TabIndex = 3;
            titelLabel.Text = "Titel:";
            // 
            // typLabel
            // 
            typLabel.AutoSize = true;
            typLabel.Location = new System.Drawing.Point(12, 98);
            typLabel.Name = "typLabel";
            typLabel.Size = new System.Drawing.Size(36, 17);
            typLabel.TabIndex = 5;
            typLabel.Text = "Typ:";
            // 
            // standortLabel
            // 
            standortLabel.AutoSize = true;
            standortLabel.Location = new System.Drawing.Point(12, 126);
            standortLabel.Name = "standortLabel";
            standortLabel.Size = new System.Drawing.Size(66, 17);
            standortLabel.TabIndex = 7;
            standortLabel.Text = "Standort:";
            // 
            // ausgeliehenLabel
            // 
            ausgeliehenLabel.AutoSize = true;
            ausgeliehenLabel.Location = new System.Drawing.Point(12, 156);
            ausgeliehenLabel.Name = "ausgeliehenLabel";
            ausgeliehenLabel.Size = new System.Drawing.Size(89, 17);
            ausgeliehenLabel.TabIndex = 9;
            ausgeliehenLabel.Text = "ausgeliehen:";
            // 
            // bestandLabel
            // 
            bestandLabel.AutoSize = true;
            bestandLabel.Location = new System.Drawing.Point(12, 186);
            bestandLabel.Name = "bestandLabel";
            bestandLabel.Size = new System.Drawing.Size(63, 17);
            bestandLabel.TabIndex = 11;
            bestandLabel.Text = "bestand:";
            // 
            // buch2020DataSet
            // 
            this.buch2020DataSet.DataSetName = "Buch2020DataSet";
            this.buch2020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mediumBindingSource
            // 
            this.mediumBindingSource.DataMember = "Medium";
            this.mediumBindingSource.DataSource = this.buch2020DataSet;
            this.mediumBindingSource.Filter = "ausgeliehen = 0 and bestand = 0";
            // 
            // mediumTableAdapter
            // 
            this.mediumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KundeTableAdapter = null;
            this.tableAdapterManager.MediumTableAdapter = this.mediumTableAdapter;
            this.tableAdapterManager.ReservierungTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Buch2020.Buch2020DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VertragTableAdapter = null;
            // 
            // mNummerTextBox
            // 
            this.mNummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "mNummer", true));
            this.mNummerTextBox.Location = new System.Drawing.Point(122, 39);
            this.mNummerTextBox.Name = "mNummerTextBox";
            this.mNummerTextBox.Size = new System.Drawing.Size(173, 22);
            this.mNummerTextBox.TabIndex = 2;
            // 
            // titelTextBox
            // 
            this.titelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "titel", true));
            this.titelTextBox.Location = new System.Drawing.Point(122, 65);
            this.titelTextBox.Name = "titelTextBox";
            this.titelTextBox.Size = new System.Drawing.Size(173, 22);
            this.titelTextBox.TabIndex = 4;
            // 
            // typTextBox
            // 
            this.typTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "typ", true));
            this.typTextBox.Location = new System.Drawing.Point(122, 93);
            this.typTextBox.Name = "typTextBox";
            this.typTextBox.Size = new System.Drawing.Size(173, 22);
            this.typTextBox.TabIndex = 6;
            // 
            // standortTextBox
            // 
            this.standortTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mediumBindingSource, "standort", true));
            this.standortTextBox.Location = new System.Drawing.Point(122, 121);
            this.standortTextBox.Name = "standortTextBox";
            this.standortTextBox.Size = new System.Drawing.Size(173, 22);
            this.standortTextBox.TabIndex = 8;
            // 
            // ausgeliehenCheckBox
            // 
            this.ausgeliehenCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediumBindingSource, "ausgeliehen", true));
            this.ausgeliehenCheckBox.Location = new System.Drawing.Point(107, 151);
            this.ausgeliehenCheckBox.Name = "ausgeliehenCheckBox";
            this.ausgeliehenCheckBox.Size = new System.Drawing.Size(173, 43);
            this.ausgeliehenCheckBox.TabIndex = 10;
            this.ausgeliehenCheckBox.UseVisualStyleBackColor = true;
            // 
            // bestandCheckBox
            // 
            this.bestandCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.mediumBindingSource, "bestand", true));
            this.bestandCheckBox.Location = new System.Drawing.Point(107, 181);
            this.bestandCheckBox.Name = "bestandCheckBox";
            this.bestandCheckBox.Size = new System.Drawing.Size(173, 43);
            this.bestandCheckBox.TabIndex = 12;
            this.bestandCheckBox.UseVisualStyleBackColor = true;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "von {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // mediumBindingNavigatorSaveItem
            // 
            this.mediumBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mediumBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mediumBindingNavigatorSaveItem.Image")));
            this.mediumBindingNavigatorSaveItem.Name = "mediumBindingNavigatorSaveItem";
            this.mediumBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.mediumBindingNavigatorSaveItem.Text = "Daten speichern";
            this.mediumBindingNavigatorSaveItem.Click += new System.EventHandler(this.mediumBindingNavigatorSaveItem_Click);
            // 
            // mediumBindingNavigator
            // 
            this.mediumBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mediumBindingNavigator.BindingSource = this.mediumBindingSource;
            this.mediumBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mediumBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mediumBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.mediumBindingNavigatorSaveItem});
            this.mediumBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mediumBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mediumBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mediumBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mediumBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mediumBindingNavigator.Name = "mediumBindingNavigator";
            this.mediumBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mediumBindingNavigator.Size = new System.Drawing.Size(322, 27);
            this.mediumBindingNavigator.TabIndex = 0;
            this.mediumBindingNavigator.Text = "bindingNavigator1";
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
            // vertragBindingSource
            // 
            this.vertragBindingSource.DataMember = "FK_Medium_Vertrag";
            this.vertragBindingSource.DataSource = this.mediumBindingSource;
            // 
            // vertragTableAdapter
            // 
            this.vertragTableAdapter.ClearBeforeFill = true;
            // 
            // reservierungBindingSource
            // 
            this.reservierungBindingSource.DataMember = "FK_Medium_Reservierung";
            this.reservierungBindingSource.DataSource = this.mediumBindingSource;
            // 
            // reservierungTableAdapter
            // 
            this.reservierungTableAdapter.ClearBeforeFill = true;
            // 
            // MedienEinzel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 275);
            this.Controls.Add(mNummerLabel);
            this.Controls.Add(this.mNummerTextBox);
            this.Controls.Add(titelLabel);
            this.Controls.Add(this.titelTextBox);
            this.Controls.Add(typLabel);
            this.Controls.Add(this.typTextBox);
            this.Controls.Add(standortLabel);
            this.Controls.Add(this.standortTextBox);
            this.Controls.Add(ausgeliehenLabel);
            this.Controls.Add(this.ausgeliehenCheckBox);
            this.Controls.Add(bestandLabel);
            this.Controls.Add(this.bestandCheckBox);
            this.Controls.Add(this.mediumBindingNavigator);
            this.Name = "MedienEinzel";
            this.Text = "Detailanzeige Medium";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MedienEinzel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buch2020DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mediumBindingNavigator)).EndInit();
            this.mediumBindingNavigator.ResumeLayout(false);
            this.mediumBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kundeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertragBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservierungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buch2020DataSet buch2020DataSet;
        private System.Windows.Forms.BindingSource mediumBindingSource;
        private Buch2020DataSetTableAdapters.MediumTableAdapter mediumTableAdapter;
        private Buch2020DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox mNummerTextBox;
        private System.Windows.Forms.TextBox titelTextBox;
        private System.Windows.Forms.TextBox typTextBox;
        private System.Windows.Forms.TextBox standortTextBox;
        private System.Windows.Forms.CheckBox ausgeliehenCheckBox;
        private System.Windows.Forms.CheckBox bestandCheckBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton mediumBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator mediumBindingNavigator;
        private System.Windows.Forms.BindingSource kundeBindingSource;
        private Buch2020DataSetTableAdapters.KundeTableAdapter kundeTableAdapter;
        private System.Windows.Forms.BindingSource vertragBindingSource;
        private Buch2020DataSetTableAdapters.VertragTableAdapter vertragTableAdapter;
        private System.Windows.Forms.BindingSource reservierungBindingSource;
        private Buch2020DataSetTableAdapters.ReservierungTableAdapter reservierungTableAdapter;
    }
}