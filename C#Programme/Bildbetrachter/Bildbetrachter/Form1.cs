using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAnzeigen_Click(object sender, EventArgs e)
        {
            //wenn ein Eintrag im Eingabefeld steht, laden wir das entsprechende Bild
            if (textBox1.Text != String.Empty)
            {
                //existiert die Datei überhaupt?
                if (System.IO.File.Exists(textBox1.Text))
                {
                    //wenn ja, dann laden und anzeigen
                    pictureBox1.Load(textBox1.Text);
                    if (checkBoxFenster.Checked == true)
                    {
                        //das neue Formular anzeigen
                        FormMax neuesFormular = new FormMax();
                        //das Formular modal anzeigen
                        neuesFormular.BildLaden(textBox1.Text);
                        neuesFormular.Text = "Große Darstellung - " + (openFileDialog1.FileName.ToString());
                        neuesFormular.ShowDialog();
                    }

                    else
                        //wenn ja, dann laden und anzeigen
                        pictureBox1.Load(textBox1.Text);
                }
                else
                    MessageBox.Show("Die Datei existiert nicht!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private void checkBoxGröße_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGröße.Checked == true)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
             else
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonÖffnen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //den Namen der ausgewählten Datei in das Eingabefeld schreiben
            textBox1.Text = openFileDialog1.FileName;

            //die eigene Methode buttonAnzeigen_Click() aufrufen
            buttonAnzeigen_Click(sender, e);
        }
     
        private void checkBoxFenster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFenster.Checked == true)
            {
                FormMax neuesFormular = new FormMax();
                //das Formular anzeigen
                neuesFormular.BildLaden(textBox1.Text);
                neuesFormular.Text = "Große Darstellung - " + (openFileDialog1.FileName.ToString());
                neuesFormular.Show();
                
            }

        }
        private FormMax fensterBilderschau;
        private void buttonBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            //ein neues Array vom TYp string anlegen und die markierten Namen kopieren
            string[] dateien = openFileDialog2.FileNames;

            //wenn sich noch Einträge in dem Listenfeld befinden löschen wir sie
            if (listBox1.Items.Count != 0)
                listBox1.Items.Clear();

            //die Namen in das Listenfeld kopieren
            foreach (string datei in dateien)
                listBox1.Items.Add(datei);
        }

        private void buttonAuswahl_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ist der letzte Eintrag noch nicht erreicht
            if (listBox1.SelectedIndex < listBox1.Items.Count -1)
            {
                //den nächsten Eintrag markieren
                listBox1.SelectedIndex++;
                //und das Bild laden
                fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());
                fensterBilderschau.Text = "Bilderschau - " + "Bild " + (listBox1.SelectedIndex + 1) + " von " + listBox1.Items.Count + " " + (listBox1.SelectedItem.ToString());
                System.Media.SystemSounds.Asterisk.Play();
            }
            //beim letzten Bild wieder aufräumen
            else
            {
                //die Markierung löschen
                listBox1.SelectedIndex = -1;
                //den Timer stoppen
                timer1.Stop();
                //das Fenster Bilderschau schließen
                fensterBilderschau.Close();
            }
        }
        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            //befinden sich überhaupt Einträge in der Liste??
            //wenn nicht, erzeugen wir eine Meldung und verlassen die Methode wieder

            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Sie müssen erst Dateien auswählen!", "Fehler");
                return;
            }
            //ist kein Eintrag im Listenfeld markiert?
            //dann den ersten Eintrag markieren
            if (listBox1.SelectedIndex == -1)
                listBox1.SelectedIndex = 0;
            //ein neues Fenster für die Bilderschau erzeugen
            fensterBilderschau = new FormMax();
            //das erste Bild laden
            fensterBilderschau.BildLaden(listBox1.SelectedItem.ToString());

            //den Titel des Formulars auf Bilderschau setzen
            fensterBilderschau.Text = "Bilderschau - " + "Bild " + (listBox1.SelectedIndex + 1) + " von " + listBox1.Items.Count + " " + (listBox1.SelectedItem.ToString());
            //das Systemmenü und das Schließsymbol ausblenden
            fensterBilderschau.ControlBox = true;
            
            //das Formular anzeigen
            fensterBilderschau.Show();
            //hier ändere ich den Interval vom Timer über das Steuerelement
            //numericUpDown das ich in einen Datentyp Int konvertieren und mit 1000 multipliziere
            //damit bei der Eingabe von 10 auch 10 Sekunden vergehen bis der nächste Tick ausgelöst wird
            //für den Fall das keine Eingabe erfolgt ist der Wert automatisch auf 1000 also Eine Sekunde
            if (numericUpDown1.Value == 0)
            timer1.Interval = 1000;
            else
            timer1.Interval = Decimal.ToInt16(numericUpDown1.Value*1000);
            timer1.Start();

            
        }
        private void tabPageEinzel_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonAnzeigen;
        }
        private void tabPageSchau_Enter(object sender, EventArgs e)
        {
            AcceptButton = buttonStart;
        }
     
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            //die Einstellungen für das Steuerelement
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 100;
            //die Einstellung für die Schrittweise änderung nach oben bzw nach unten 
            numericUpDown1.Increment = 1;
            //diese Einstellung bewirkt das keine Komma stellen angezeigt werden
            numericUpDown1.DecimalPlaces = 0;
           
        }

    }
}
