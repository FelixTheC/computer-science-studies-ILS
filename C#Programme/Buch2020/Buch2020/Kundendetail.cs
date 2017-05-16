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
    public partial class Kundendetail : Form
    {
        public void DetailsLaden(int nummer)
        {
            this.kundeTableAdapter.FillBykundeDetail(this.buch2020DataSet.Kunde, nummer);
        }

        //die Abfrag bzw die Methode für die Abfrage des Kundennamen
        public void KundeFinden(string name)
        {
            this.kundeTableAdapter.FillBykundeSuchen(this.buch2020DataSet.Kunde, name);
        }

        public Kundendetail()
        {
            InitializeComponent();
        }

        private void kundeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kundeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.buch2020DataSet);

        }

        private void Kundendetail_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "buch2020DataSet.Kunde". Sie können sie bei Bedarf verschieben oder entfernen.
            //this.kundeTableAdapter.Fill(this.buch2020DataSet.Kunde);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kNummerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vornameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
