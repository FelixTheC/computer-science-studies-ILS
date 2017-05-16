using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHP_7B7._4
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
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 1);
            if (label1.Location.Y > 300)
                label1.Location = new Point(112, 0);
            if (label1.Location.Y >= 300)
                zaehler++;
            if (zaehler > 10)
                Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
