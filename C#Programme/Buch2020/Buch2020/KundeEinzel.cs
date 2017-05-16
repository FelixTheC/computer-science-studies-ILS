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
    public partial class KundeEinzel : Form
    {

        public void DetailsLaden(int nummer)
        {
            this.kundeTableAdapter.FillBykundeDetail(this.buch2020DataSet.Kunde, nummer);
        }

        public KundeEinzel()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void KundeEinzel_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);
        }


        private void kNameTextBox_Validating(object sender, CancelEventArgs e)
        {
                kNameTextBox.MaxLength = 50;

                if (kNameTextBox.Text.Length == 0)
                {
                    MessageBox.Show("Bitte geben Sie einen gültigen Namen ein");
                    kNameTextBox.Select();
                }
         }
        
        private void postleitzahlTextBox_Validating(object sender, CancelEventArgs e)
        {
            int tempPostleitzahl = 0;
            postleitzahlTextBox.MaxLength = 5;
            if ((postleitzahlTextBox.TextLength != 5) || (Int32.TryParse(postleitzahlTextBox.Text, out tempPostleitzahl) == false))
            {
                MessageBox.Show("Bitte geben Sie eine gültige Postleitzahl ein");
                postleitzahlTextBox.Select();
            }
        }

        private void vornameTextBox_Validating(object sender, CancelEventArgs e)
        {
            vornameTextBox.MaxLength = 50;
            if (vornameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Vornamen ein");
                vornameTextBox.Select();
            }
        }

        private void strasseTextBox_Validating(object sender, CancelEventArgs e)
        {
            strasseTextBox.MaxLength = 50;
            if (strasseTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte geben Sie eine gültige Strasse ein");
                strasseTextBox.Select();
            }
        }

        private void ortTextBox_Validating(object sender, CancelEventArgs e)
        {
            ortTextBox.MaxLength = 50;
            if (ortTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Ort ein");
                ortTextBox.Select();
            }
        }

        private void telefon1TextBox_Validating(object sender, CancelEventArgs e)
        {
            telefon1TextBox.MaxLength = 20;
        }

        private void telefon2TextBox_Validating(object sender, CancelEventArgs e)
        {
            telefon2TextBox.MaxLength = 20;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            kNameTextBox.Visible = true;
            vornameTextBox.Visible = true;
            strasseTextBox.Visible = true;
            postleitzahlTextBox.Visible = true;
            ortTextBox.Visible = true;
            telefon1TextBox.Visible = true;
            telefon2TextBox.Visible = true;
        }

        private void KundeEinzel_Shown(object sender, EventArgs e)
        {
           
        }

        private void kNummerTextBox_Validating(object sender, CancelEventArgs e)
        {
            //kNummerTextBox.Visible = false;
        }

        private void KundeEinzel_Load_1(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Medium". Sie können sie bei Bedarf verschieben oder entfernen.
            this.mediumTableAdapter.Fill(this.buch2020DataSet.Medium);
            kNameTextBox.Visible = false;
            vornameTextBox.Visible = false;
            strasseTextBox.Visible = false;
            postleitzahlTextBox.Visible = false;
            ortTextBox.Visible = false;
            telefon1TextBox.Visible = false;
            telefon2TextBox.Visible = false;
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Reservierung". Sie können sie bei Bedarf verschieben oder entfernen.
            this.reservierungTableAdapter.Fill(this.buch2020DataSet.Reservierung);
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Vertrag". Sie können sie bei Bedarf verschieben oder entfernen.
            this.vertragTableAdapter.Fill(this.buch2020DataSet.Vertrag);
            
        }

        private void mediumDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
