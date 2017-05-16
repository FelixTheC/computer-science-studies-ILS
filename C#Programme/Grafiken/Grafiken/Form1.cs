using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafiken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kreisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics zeichenfläche;
            zeichenfläche = this.CreateGraphics();
            Pen stift = new Pen(Color.Black);
            zeichenfläche.DrawEllipse(stift, 10, 30, 100, 100);
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics zeichenfläche;
            zeichenfläche = this.CreateGraphics();
            Pen stift = new Pen(Color.Black);
            zeichenfläche.DrawEllipse(stift, 10, 200, 100, 50);
        }

        private void kreisImQuadratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics zeichenfläche;
            zeichenfläche = this.CreateGraphics();
            Pen stift = new Pen(Color.Black);
            zeichenfläche.DrawRectangle(stift, 150, 50, 100, 100);
            zeichenfläche.DrawEllipse(stift, 150, 50, 100, 100);
        }

    }
}
