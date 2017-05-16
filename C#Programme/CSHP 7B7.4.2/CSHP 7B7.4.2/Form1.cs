using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP_7B7._4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int zaehler = 0;
            int zaehler2 = 0;
         
                label1.Top++;
                zaehler++;
          
            if (zaehler >= 300)
            {
                label1.Top = 0;
                zaehler2++;
            }


        }
    }
}
