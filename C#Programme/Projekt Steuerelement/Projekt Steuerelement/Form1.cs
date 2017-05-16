using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Steuerelement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdPositionRel_Click(object sender, EventArgs e)
        {
            cmdTest.Location = new Point(cmdTest.Location.X + 20, cmdTest.Location.Y);
        }

        private void cmdPositionAbs_Click(object sender, EventArgs e)
        {
            cmdTest.Location = new Point(100, 200);
        }

        private void cmdGroeßeRel_Click(object sender, EventArgs e)
        {
            cmdTest.Size = new Size(cmdTest.Size.Width + 20, cmdTest.Size.Height);
        }

        private void cmdGroeßeAbs_Click(object sender, EventArgs e)
        {
            cmdTest.Size = new Size(50, 75);
        }

        private void cmdAnzeige_Click(object sender, EventArgs e)
        {
            lblAnzeige.Text = "Position: X:" + cmdTest.Location.X + ", Y:" + cmdTest.Location.Y + "\n" + "Größe: Breite:"
            + cmdTest.Size.Width + " Höhe" + cmdTest.Size.Height;
        }
    }
}
