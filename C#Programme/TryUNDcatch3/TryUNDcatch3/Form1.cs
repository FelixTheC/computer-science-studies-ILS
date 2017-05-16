using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryUNDcatch3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ergebnis, zahl2, zahl1 = 10;

            //Konvertierung und Berechung werden versucht
            try
            {
                zahl2 = Convert.ToInt32(textBox1.Text);
                ergebnis = zahl1 / zahl2;
                MessageBox.Show("Das Ergebnis ist " + ergebnis, "Hurra");
            }
            catch(FormatException)
            {
                MessageBox.Show("Da ist etwas schief gegangen", "Oh nein");
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show("Eine Division durch 0 ist nicht Definiert", "Oh nein");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
