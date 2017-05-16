using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP_7B7._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;
            zahl1 = Convert.ToSingle(textBoxZahl1.Text);
            zahl2 = Convert.ToSingle(textBoxZahl2.Text);
            if (comboBox1.SelectedIndex == 0)
                ergebnis = zahl1 + zahl2;
            if (comboBox1.SelectedIndex == 1)
                ergebnis = zahl1 - zahl2;
            if (comboBox1.SelectedIndex == 2)
                ergebnis = zahl1 * zahl2;
            if (comboBox1.SelectedIndex == 3)
                if (zahl2 == 0)
                {
                    divDurchNull = true;
                }
                else
            {
                ergebnis = zahl1 / zahl2;
            }
            if (divDurchNull == true)
                LabelAnzeige.Text = "Ihre Eingabe war ungültig";
           
            LabelAnzeige.Text = Convert.ToString(ergebnis);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
