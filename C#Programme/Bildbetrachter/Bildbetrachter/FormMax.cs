﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bildbetrachter
{
    public partial class FormMax : Form
    {
        public FormMax()
        {
            InitializeComponent();
        }
        
        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            
        }
        public void BildLaden(string bildName)
        {
            pictureBoxMax.Load(bildName);
        }

        private void FormMax_Load(object sender, EventArgs e)
        {
            
        }
    }
}
