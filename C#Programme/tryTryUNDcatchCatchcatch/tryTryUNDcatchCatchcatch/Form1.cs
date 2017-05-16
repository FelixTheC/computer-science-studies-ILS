using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tryTryUNDcatchCatchcatch
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
            //die Konvertierung im äußeren try-Block
            try
            {
                zahl2 = Convert.ToInt32(textBox1.Text);
                //die berechnung im inneren try-Block
                try
                {
                    ergebnis = zahl1 / zahl2;

                    MessageBox.Show("Das Ergebnis ist "+ergebnis ,"Hurra");
                }
                //catch für den inneren Block
                catch(DivideByZeroException)
                {
                    MessageBox.Show("Eine Division durch Null ist nicht definiert", "Oh NEIN");
                }
            }
            //catch für den äußeren Block
            catch(FormatException)
            {
                MessageBox.Show("Bei der Konvertierung ist etwas schief gelaufen","So nicht");
            }
            catch
            {
                MessageBox.Show("Ein anderes Problem ist aufgetreten","Was ist DAS");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                button1_Click(sender, e);
            }
        }
    }
}
