using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace einfscher_Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        
        private void beenden_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void berechnen_Click(object sender, EventArgs e)
        {

            float zahl1, zahl2, ergebnis = 0;
            bool divDurchNull = false;
          
                //die beiden Zahlen einlesen und konvertieren

                    zahl1 = Convert.ToSingle(BoxZahl1.Text);
                    zahl2 = Convert.ToSingle(BoxZahl2.Text);
               
                //die Rechenoperation ermitteln und durchführen
                if (radioButtonAddition.Checked == true)
                {
                    ergebnis = zahl1 + zahl2;
                }
                if (radioButtonSubtraktion.Checked == true)
                {
                    ergebnis = zahl1 - zahl2;
                }
                if (radioButtonMultiplikation.Checked == true)
                {
                    ergebnis = zahl1 * zahl2;
                }
                if (radioButtonDivision.Checked == true)
                    if (zahl2 == 0)
                    {
                        divDurchNull = true;
                    }
                    else
                    {
                        ergebnis = zahl1 / zahl2;
                    }
                if (divDurchNull == true)
                    label1.Text = "Nicht definiert!";
                else
                    label1.Text = Convert.ToString(ergebnis);
        }
      

        private void BoxZahl1_TextChanged(object sender, EventArgs e)
        {
            try
             {
                 float zahl;
                 zahl = Convert.ToSingle(BoxZahl1.Text);
                 berechnen.Enabled = true;
             }
           catch(FormatException)
           {
               MessageBox.Show("Ihre Eingabe: '"+ BoxZahl1.Text + "' ist ungültig", "Gefahr");
               BoxZahl1.SelectAll();
               berechnen.Enabled = false;
           }

        }

        private void BoxZahl2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float zahl;
                zahl = Convert.ToSingle(BoxZahl2.Text);
                berechnen.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Ihre Eingabe: " + BoxZahl2.Text + " ist ungültig", "Gefahr");
                BoxZahl2.SelectAll();
                berechnen.Enabled = false;
            }

        } 
    }
}
