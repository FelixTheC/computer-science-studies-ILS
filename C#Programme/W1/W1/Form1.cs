using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1
{
    public partial class ÜName : Form
    {
        public ÜName()
        {
            InitializeComponent();
        }

        private void ÜName_Load(object sender, EventArgs e)
        {

        }

        private void MyName_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Felix Eisenmenger";
        }

        private void cmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
