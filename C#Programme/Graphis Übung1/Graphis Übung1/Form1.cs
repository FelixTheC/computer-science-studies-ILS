using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphis_Übung1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eine Variable vom Typ Graphics
            Graphics Zeichenfläche;

            //die Variable auf die Zeichenfläche des Formulars setzen
            Zeichenfläche = this.CreateGraphics();
           
            //einen schwarzen Stift erzeugen
            Pen stift = new Pen(Color.Black);

            //eine Variable vom typ Rectngle
            Rectangle bereich;

            //den Client-bereich beschaffen
            bereich = ClientRectangle;
            bereich.Height = bereich.Height - 10;
            bereich.Width = bereich.Width - 10;
            bereich.Location = new Point(5, 5);
            //ein Rechteck in die Zeichenfläche des Formulars zeichnen

           Zeichenfläche.DrawRectangle(stift, 50, 50, 100, 100);
            Zeichenfläche.DrawRectangle(stift, bereich);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen stift = new Pen(Color.Black);
            Graphics Zeichenfläche;
            Zeichenfläche = this.CreateGraphics();
            Zeichenfläche.Clear(BackColor);
            Rectangle bereich;
            bereich = ClientRectangle;

            int aufrufe = 0;

            if(aufrufe < 30)
            {
                bereich.Height = bereich.Height - 10;
                bereich.Width = bereich.Width - 10;

                bereich.Location = new Point(bereich.Location.X + 5, bereich.Location.Y + 5);
                Zeichenfläche.DrawRectangle(stift, bereich);
                aufrufe++;
            }
        }
    }
}
