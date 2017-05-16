using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniWebBrowser
{
    public partial class URLOeffnenDialog : Form
    {
        public URLOeffnenDialog()
        {
            InitializeComponent();
        }

        private void buttonAbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
        public string LieferAdresse()
        {
            return textBox1.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //die Schaltfläche Öffnen aktivieren, wenn das Feld nicht leer ist
           if(textBox1.Text != string.Empty)
           {
               buttonOeffnen.Enabled = true;
           }
           else
           {
               buttonOeffnen.Enabled = false;
           }
        }

        private void buttonOeffnen_Click(object sender, EventArgs e)
        {

        }

        private void Öffnen(object sender, DragEventArgs e)
        {

        }
    }
}
