using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alles_mögliche_an_Grafiken
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics zeichenflaeche = CreateGraphics();
            Pen stift = new Pen(Color.Black);
            Brush pinsel = new SolidBrush(Color.Blue);

            //die Zeichenfläche löschen
            zeichenflaeche.Clear(BackColor);

            //ein Polygon
            //dafür brauchen wir erstmal ein Array
            Point[] punkte = new Point[5];
            punkte[0] = new Point(10, 10);
            punkte[1] = new Point(60, 20);
            punkte[2] = new Point(110, 90);
            punkte[3] = new Point(270, 150);
            punkte[4] = new Point(200, 20);

            zeichenflaeche.DrawPolygon(stift, punkte);
            

            //die Farbe des Stiftes ändern
            stift.Color = Color.Red;

            //ein Rechteck zeichnen
            zeichenflaeche.DrawRectangle(stift, 10, 250, 100, 100);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics zeichenflaeche = CreateGraphics();
            Pen stift = new Pen(Color.Black);
            Brush pinsel = new SolidBrush(Color.Blue);
            //jetzt wird der Stift grün
            stift.Color = Color.Green;

            //der Linienstil gestrichelt
            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;

            //der Stift wird jetzt etwas dicker
            stift.Width = 3;

            //eine Linie zeichen
            zeichenflaeche.DrawLine(stift, 0, 120, 100, 120);

            //wie wäre es mal mit Blau
            stift.Color = Color.Blue;
            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            zeichenflaeche.DrawLine(stift, 0, 140, 100, 140);

            //und nocheinmal

            stift.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            stift.Width = 10;
            zeichenflaeche.DrawLine(stift, 0, 160, 100, 160);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Graphics zeichenflaeche = CreateGraphics();
            Pen stift = new Pen(Color.Black);
            Brush pinsel = new SolidBrush(Color.Blue);

            //nun auch den Pinsel ändern
            pinsel = new SolidBrush(Color.Red);

            //ein Rechteck ausmalen 
            zeichenflaeche.FillRectangle(pinsel, 150, 250, 90, 90);
        }

        private void button4_Click(object sender, EventArgs e)
        {
             Graphics zeichenflaeche = CreateGraphics();
            Pen stift = new Pen(Color.Black);
            Brush pinsel = new SolidBrush(Color.Blue);
             //einen Pinsel für ein Muster erzeugen wichtig
            //es läuft über einen Konstruktor

            System.Drawing.Drawing2D.HatchBrush musterPinsel = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.Cross, Color.Blue, Color.Green);

            zeichenflaeche.FillRectangle(musterPinsel, 150, 110, 90, 90);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Graphics zeichenflaeche = CreateGraphics();
            zeichenflaeche.Clear(BackColor);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Graphics zeichenflaeche = CreateGraphics();

            System.Drawing.Drawing2D.LinearGradientBrush verlaufPinsel = new System.Drawing.Drawing2D.LinearGradientBrush(new Point(10, 10), new Point(300, 300), Color.Red, Color.Blue);
            zeichenflaeche.FillRectangle(verlaufPinsel, 10, 10, 200, 200);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Rectangle bereich;
            Graphics zeichenflaeche = CreateGraphics();
            zeichenflaeche.Clear(BackColor);
            Pen stift = new Pen(Color.Black);
            Brush pinsel = new SolidBrush(Color.Blue);

            //die Schrifart setzen
            System.Drawing.Font schrift = new System.Drawing.Font("Arial", 12);

            //ausgabe in einem Rechteck
            bereich = ClientRectangle;
            bereich.Width = 100;
            bereich.Height = 200;
            bereich.Location = new Point(100, 100);

            zeichenflaeche.DrawRectangle(stift, bereich);
            zeichenflaeche.DrawString("Ich stehe in einem Rechteck" ,schrift, pinsel, bereich);
        }
    }
}
