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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonListe_Click(object sender, EventArgs e)
        {
            Kundenliste kListe = new Kundenliste();
            kListe.ShowDialog();
        }

        private void buttonEinzel_Click(object sender, EventArgs e)
        {
            KundeEinzel kEinzelListe = new KundeEinzel();
            kEinzelListe.ShowDialog();
        }

        private void buttonMedien_Click(object sender, EventArgs e)
        {
            MedienListe mListe = new MedienListe();
            mListe.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedienEinzel mEinzel = new MedienEinzel();
            mEinzel.ShowDialog();
           
        }

        private void buttonVertrag_Click(object sender, EventArgs e)
        {
            VertragEinzel vertrag = new VertragEinzel();
            vertrag.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reservierung reservierung = new Reservierung();
            reservierung.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kundensuche kundeSuchen = new Kundensuche();
            kundeSuchen.ShowDialog();
        }
    }
}
