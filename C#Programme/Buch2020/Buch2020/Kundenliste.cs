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
    public partial class Kundenliste : Form
    {
        Color alteFarbe;

        public Kundenliste()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kundeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Kundenliste_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Reservierung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungTableAdapter.Fill(this.buch2020DataSet.Reservierung);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.buch2020DataSet.Vertrag);
            

        }

        private void kundeDataGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void kundeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //für die zusätzliche Prüfung der Postleitzahl
            bool fehlerKeinEintrag = false;
            int postleitzahltemp = 0;
            //überprüft werden nur die Splaten 2 bis 6
            //der Index beginnt bei 0!
            if ((e.ColumnIndex > 0) && (e.ColumnIndex < 6))
            {
                //ist der Eintrag leer?
                if (e.FormattedValue.ToString() == string.Empty)
                { 
                    //eine Meldung anzeigen
                    MessageBox.Show("Sie müssen einen Wert für " + kundeDataGridView.Columns[e.ColumnIndex].HeaderText + " eingeben.");

                    //den Fehlertext setzen
                    kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "Die Zelle darf nicht leer sein!";

                    //die Aktion abbrechen
                    e.Cancel = true;
                    //fehlerKeinEintrag wird true, da die weiteren Prüfungen für die 
                    //Postleitzahl nicht mehr erforderlich sind
                    fehlerKeinEintrag = true;
                }
            }
            //die Detailprüfung für die Postleitzahl
            //sind wir in der Spalte für die Postleitzahl und ist kein Einrag vorhanden
            if ((e.ColumnIndex == 4) && (fehlerKeinEintrag == false))
            { 
                //ist der Eintrag exakt fünf zeichen lang
                if (e.FormattedValue.ToString().Length != 5)
                {
                    MessageBox.Show("Die Postleitzahl muss exakt fünf Zeichen lang sein");
                    e.Cancel = true;
                }
                //sind es nur Ziffern
                else
                {
                    if (Int32.TryParse(e.FormattedValue.ToString(), out postleitzahltemp) == false)
                    {
                        MessageBox.Show("Das Format der Postleitzahl ist ungültig");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void kundeDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText != string.Empty)
                kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = string.Empty;
        }

        private void kundeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                this.Validate();
                this.kundeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.buch2020DataSet);
            }
            catch
            {
                MessageBox.Show("Beim Speichern ist ein Fehler aufgetreten! \nBitte überprüfen Sie ihre Eingaben.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kundeDataGridView_MouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void kundeDataGridView_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zelle?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            {
                //für den leichteren Zugriff
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];

                //die alte Farbe sichern
                alteFarbe = zelle.Style.BackColor;

                //die neue Farbe setzen
                zelle.Style.BackColor = Color.LightBlue;
            }
        }

        private void kundeDataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            //befindet sich die Maus über einer Zelle?
            if ((e.ColumnIndex != -1) && (e.RowIndex != -1))
            { 
                //für den leichteren Zugriff
                DataGridViewCell zelle = kundeDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                //die alte Farbe wiederherstellen

                zelle.Style.BackColor = alteFarbe;
            }
        }
    }
}
