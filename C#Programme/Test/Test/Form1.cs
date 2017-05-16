using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void testButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonBerechnen_Click(object sender, EventArgs e)
        {
          
            string Ergebnis;
            if (radioButton1.Checked == true)
                Ergebnis = "textBoxZahl1" + "textBoxZahl2";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
