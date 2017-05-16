using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Übung2
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
            Pen stift = new Pen(Color.Black);

            //eine Variable vom Typ Rectangel erstellen
            Rectangle bereich;

            //den Client-bereich beschaffen
            bereich = ClientRectangle;

            //in einer Schleife anpassen
            for(int durchlauf = 0; durchlauf < 40; durchlauf++)
            {
                //jeweils 10 von der Höhe und der Breite abziehen
                bereich.Width = bereich.Width - 10;
                bereich.Height = bereich.Height - 10;

                //den Startpunkt setzen
                bereich.Location = new Point(bereich.Location.X + 5, bereich.Location.Y + 5);

                //ein Rechteck zeichnen
                e.Graphics.DrawRectangle(stift, bereich);

                //einen Moment warten
                System.Threading.Thread.Sleep(100);

                //den Zeichenbereich löschen
                e.Graphics.Clear(BackColor);
            }
        }
    }
}
