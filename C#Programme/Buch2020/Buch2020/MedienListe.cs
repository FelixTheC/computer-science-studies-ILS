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
    public partial class MedienListe : Form
    {
        public MedienListe()
        {
            InitializeComponent();
        }

        private void mediumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mediumBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void MedienListe_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Reservierung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungTableAdapter.Fill(this.buch2020DataSet.Reservierung);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.buch2020DataSet.Vertrag);

        }
    }
}
