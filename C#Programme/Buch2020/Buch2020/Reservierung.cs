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
    public partial class Reservierung : Form
    {
        public Reservierung()
        {
            InitializeComponent();
        }

        private void reservierungBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservierungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Reservierung_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Reservierung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungTableAdapter.Fill(this.buch2020DataSet.Reservierung);

            //sind überhaupt Medien zur Reservierung verfügbar
            if (mNummerComboBox.Items.Count == 0)
            {
                MessageBox.Show("Es stehen derzeit keine Medien zur Reservierung zur Verfügung", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //einen neuen Datensatz erzeugen
                reservierungBindingSource.AddNew();
                //den Wert für das Medium setzen
                mNummerComboBox.SelectedIndex = 0;
                //den Wert für die Kunden setzen
                kNummerComboBox.SelectedIndex = 0;
                //den Wert für das Reservierungsdatum setzen
                gueltigBisDateTimePicker.Value = DateTime.Now.AddDays(30);
            }
        }

        private void buttonUebernehmen_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reservierungBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            Close();
        }

        private void buttonAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MedienEinzel detailMedieAnzeigen = new MedienEinzel();
            detailMedieAnzeigen.DetailsLaden(Convert.ToInt32(mNummerComboBox.SelectedValue));
            detailMedieAnzeigen.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kundendetail detailKundeAnzeigen = new Kundendetail();
            detailKundeAnzeigen.DetailsLaden(Convert.ToInt32(kNummerComboBox.SelectedValue));
            detailKundeAnzeigen.ShowDialog();
        }
    }
}
