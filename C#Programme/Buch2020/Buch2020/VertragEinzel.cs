using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buch2020
{
    public partial class VertragEinzel : Form
    {
        public VertragEinzel()
        {
            InitializeComponent();
        }

        private void vertragBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vertragBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void VertragEinzel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.buch2020DataSet.Vertrag);

            if (mNummerComboBox.Items.Count == 0)
            {
                MessageBox.Show("Es stehen derzeit keine Medien zur verfügung", "Ausnahme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            if (kNummerComboBox.Items.Count == 0)
            {
                MessageBox.Show("Es wurden noch keine Kunden erstellt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            //einen neuen Datensatz erzeugen
            vertragBindingSource.AddNew();
            //die Einträge für den Kunden und das Medium setzen
            kNummerComboBox.SelectedIndex = 0;
            mNummerComboBox.SelectedIndex = 0;
            //den Wert für das Ausleihdatum setzen
            gueltigAbDateTimePicker.Value = DateTime.Now;
            gueltigBisDateTimePicker.Value = DateTime.Now.AddDays(30);
            

        }

        private void vNummerLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSpeichern_Click(object sender, EventArgs e)
        {
            this.vertragBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            this.Validate();
            this.mediumTableAdapter.ausgeliehenSetzen(Convert.ToInt32(mNummerComboBox.SelectedValue));
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kundendetail detail = new Kundendetail();
            detail.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kundendetail detailAnzeigenKunde = new Kundendetail();
            detailAnzeigenKunde.DetailsLaden(Convert.ToInt32(kNummerComboBox.SelectedValue));
            detailAnzeigenKunde.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MedienEinzel detailAnzeigenMedien = new MedienEinzel();
            detailAnzeigenMedien.DetailsLaden(Convert.ToInt32(mNummerComboBox.SelectedValue));
            detailAnzeigenMedien.ShowDialog();
        }

     }
}
