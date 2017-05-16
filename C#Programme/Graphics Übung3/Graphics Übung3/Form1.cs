using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Übung3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(Color.Black);

            e.Graphics.DrawRectangle(stift, 1, 1, 10, 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(Color.Black);

            e.Graphics.DrawRectangle(stift, 1, 1, 10, 10);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(Color.Black);

            e.Graphics.DrawRectangle(stift, 1, 1, 10, 10);
        }
    }
}
