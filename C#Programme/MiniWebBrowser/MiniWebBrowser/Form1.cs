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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //die URL an die Liste übergeben
            //wenn die URL nicht schon in der Liste steht
            string myString = webBrowser1.Url.ToString();
            int index = listBox1.FindString(myString,-1);
            if (index != -1)
            {
                //wenn die URL schon in der Liste steht passiert nichts
                listBox1.Items.Equals(myString);
            }
                //ansonsten wird sie hinzugefügt
            else
                listBox1.Items.Add(webBrowser1.Url);
            //den Text in der Titelleiste zusammenbauen
            Text = "MiniWebrowser - " + webBrowser1.Document.Title;
            toolStripTextBox1.Text = webBrowser1.Url.ToString();
            if (webBrowser1.CanGoBack)
            {
                toolStripMenuItemRueck.Enabled = true;
                toolStripButtonRueck.Enabled = true;
            }
            else
            {
                toolStripMenuItemRueck.Enabled = false;
                toolStripButtonRueck.Enabled = false;
            }
            if (webBrowser1.CanGoForward)
            {
                toolStripMenuItemVor.Enabled = true;
                toolStripButtonVor.Enabled = true;
            }
            else
            {
                toolStripMenuItemVor.Enabled = false;
                toolStripButtonVor.Enabled = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            string adresse;
            //den eigenen Öffnendialog öffnen und modal anzeigen
            URLOeffnenDialog oeffnenForm = new URLOeffnenDialog();
            oeffnenForm.ShowDialog();

            //wurde die Schaltfläche Öffnen in dem Dialog angeklickt
            if(oeffnenForm.DialogResult == DialogResult.OK)
            {
                //die Adresse über die Methode im Öffnendialog beschaffen
                adresse = oeffnenForm.LieferAdresse();

                //wenn die Adresse nicht leer ist, die Seite anzeigen
                if (adresse != String.Empty)
                {
                    webBrowser1.Navigate(adresse);

                    //das zweite Formular schließen
                    oeffnenForm.Close();
                }
            }
        }

        private void toolStripMenuItemVorwaerts_Click(object sender, EventArgs e)
        {
            //wenn es einen Eintrag für Vorwärts gibt, dann aufrufen
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void toolStripMenuItemRueckwaerts_Click(object sender, EventArgs e)
        {
            //wenn es einen Eintrag für Rückwärts gibt dann gehe Rückwärts
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void toolStripMenuItemNeuLaden_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripMenuItemLadenabbrechen_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripMenuItemVor_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void toolStripMenuItemRueck_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void toolStripMenuItemAbbrechen_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripMenuItemNeu_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButtonLosGehts_Click(object sender, EventArgs e)
        {
            //wenn ein Text im Eingabefeld steht, übergebn wir ihn an die Methode Navigate()
            if(toolStripTextBox1.Text != String.Empty)
            {
                webBrowser1.Navigate(toolStripTextBox1.Text);
            }
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //wenn die Eingabetaste gedrückt wird, rufen wir die Methode für die
            //Schaltfläche Los Geht´s auf
            if (e.KeyCode == Keys.Enter)
                toolStripButtonLosGehts_Click(sender, e);
        }

        private void toolStripButtonLosGehts_MouseEnter(object sender, EventArgs e)
        {
            toolStripButtonLosGehts.ToolTipText = "Los Geht´s zu " + toolStripTextBox1.Text;
        }

        private void toolStripMenuItemNavigation_Click(object sender, EventArgs e)
        {
            //die Navigationsliste ein- bzw ausblenden
            if (toolStripMenuItemNavigation.Checked)
                splitContainer1.Panel1Collapsed = false;
            else
                splitContainer1.Panel1Collapsed = true;
            //wenn das Menü aktiviert wird wird der Vollbildstatus verändert
            if (toolStripMenuItemNavigation.Checked == true)
                toolStripMenuItemVoll.Checked = false;
            //wenn die Menüs ausgeschaltet sind wird das Vollbild bzw der Eintrag im Menu abgehakt angezeigt
            if ((toolStripMenuItemNavigation.Checked == false) && (toolStripMenuItemAdresse.Checked == false) && (toolStripMenuItemNavi2.Checked == false))
                toolStripMenuItemVoll.Checked = true;
        }

        private void toolStripMenuItemAdresse_Click(object sender, EventArgs e)
        {
            //die Adresszeile ein bzw ausblenden
            if (toolStripMenuItemAdresse.Checked == true)
            {
                toolStripAdresse.Visible = true;
                toolStripMenuItemAktivieren.Checked = true;
            }
            else
            {
                toolStripAdresse.Visible = false;
                toolStripMenuItemAktivieren.Checked = false;
            }
            //wenn das Menü aktiviert wird wird der Vollbildstatus verändert
            if (toolStripMenuItemAdresse.Checked == true)
                toolStripMenuItemVoll.Checked = false;
            //wenn die Menüs ausgeschaltet sind wird das Vollbild bzw der Eintrag im Menu abgehakt angezeigt
            if ((toolStripMenuItemNavigation.Checked == false) && (toolStripMenuItemAdresse.Checked == false) && (toolStripMenuItemNavi2.Checked == false))
                toolStripMenuItemVoll.Checked = true;
        }

    
        private void toolStripMenuItemNavi2_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItemNavi2.Checked)
            {
                toolStrip1.Visible = true;
                //das Kontextmenu ebenfalls setzen
                toolStripMenuItem6.Checked = true;
            }
            else
            {
                toolStrip1.Visible = false;
                toolStripMenuItem6.Checked = false;
            }
            //wenn das Menü aktiviert wird wird der Vollbildstatus verändert
            if (toolStripMenuItemNavi2.Checked == true)
                toolStripMenuItemVoll.Checked = false;
            //wenn die Menüs ausgeschaltet sind wird das Vollbild bzw der Eintrag im Menu abgehakt angezeigt
            if ((toolStripMenuItemNavigation.Checked == false) && (toolStripMenuItemAdresse.Checked == false) && (toolStripMenuItemNavi2.Checked == false))
                toolStripMenuItemVoll.Checked = true;
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            toolStripMenuItemNavigation.Checked = false;

            splitContainer1.Panel1Collapsed = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                webBrowser1.Navigate(listBox1.SelectedItem.ToString());
        }

        private void toolStripMenuItemSort_Click(object sender, EventArgs e)
        {
            //die Liste sortiert oder unsortiert anzeigen
            if (toolStripMenuItemSort.Checked)
                listBox1.Sorted = true;
            else
                listBox1.Sorted = false;
        }

        private void toolStripMenuItemLoeschen_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItemLoeschen.Checked)
                listBox1.Items.Clear();
        }
     
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripProgressBar1.Visible = true;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //den text im Statuslabel setzen
            toolStripStatusLabel1.Text = webBrowser1.StatusText;

            //das Maximum und den aktuellen Wert für den ProgressBar setzen
            //die Werte müssen als Int32 dargestellt werden
            toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);

            toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);

            //wenn das Laden vollständig ist, den ProgessBar wieder ausblenden
            if (e.CurrentProgress == e.MaximumProgress)
                toolStripProgressBar1.Visible = false;
        }

        private void toolStripMenuItemInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmiert von Felix Eisenmenger \nCSHP 9B-XX1-N01\nVertrags-Nr.: 800308897", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItemVoll_Click(object sender, EventArgs e)
        {
                if (toolStripMenuItemVoll.Checked)
                {   //alles gewünschte ausschalten und das MenuItem auf Checked true setzen
                    //sowie die MenuItem`s Navigation und Adresse auf Checked false setzen
                    menuStrip2.Visible = false;
                    toolStrip1.Visible = false;
                    toolStripAdresse.Visible = false;
                    splitContainer1.Panel1Collapsed = true;
                    toolStripMenuItemNavigation.Checked = false;
                    toolStripMenuItemAdresse.Checked = false;
                    toolStripMenuItemNavi2.Checked = false;
                }
                if (toolStripMenuItemVoll.Checked != true)
                {
                    //alles wieder Rückgänig machen
                    menuStrip2.Visible = true;
                    toolStrip1.Visible = true;
                    toolStripAdresse.Visible = true;
                    splitContainer1.Panel1Collapsed = false;
                    toolStripMenuItemNavigation.Checked = true;
                    toolStripMenuItemAdresse.Checked = true;
                    toolStripMenuItemNavi2.Checked = true;
                }
         }


        private void toolStripMenuItemAktivieren_Click(object sender, EventArgs e)
        {
            //wenn der Kontext Aktivieren geklickt wurde wird das Menu aktiviert
            if (toolStripMenuItemAktivieren.Checked)
            {  //wenn das Kontextmenu aktiviert ist alles aktiviert lassen
                toolStripAdresse.Visible = true;
                toolStripMenuItemAdresse.Checked = true;
            }
            if (toolStripMenuItemAktivieren.Checked == false)
            {  //wenn das Kontextmenu deaktiviert wird alles deaktivieren lassen
                toolStripAdresse.Visible = false;
                toolStripMenuItemAdresse.Checked = false;
            }
        }


        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            if (toolStripMenuItem6.Checked)
            {
                //wenn das Kontextmenu aktiviert ist alles aktiviert lassen
                toolStrip1.Visible = true;
                toolStripMenuItemNavi2.Checked = true;
            }
            if (toolStripMenuItem6.Checked == false)
            {   //wenn das Kontextmenu deaktiviert wird alles deaktivieren lassen
                toolStrip1.Visible = false;
                toolStripMenuItemNavi2.Checked = false;
            }
        }

        private void contextMenuStripAktievieren1_Opening(object sender, CancelEventArgs e)
        {

        }

      
    }
}
