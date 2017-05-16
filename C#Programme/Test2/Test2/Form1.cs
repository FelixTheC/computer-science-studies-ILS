using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string zahl1;
            string zahl2;
            string ergebnis;
            zahl1 = Convert.ToString(textBox1.Text);
            zahl2 = Convert.ToString(textBox2.Text);
            
        }
    }
}
