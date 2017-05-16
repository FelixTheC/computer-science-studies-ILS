using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// Die Elementvorlage "Standardseite" ist unter http://go.microsoft.com/fwlink/?LinkId=234237 dokumentiert.

namespace CSHP23BApp
{
    /// <summary>
    /// Eine Standardseite mit Eigenschaften, die die meisten Anwendungen aufweisen.
    /// </summary>
    public sealed partial class MainPage : CSHP23BApp.Common.LayoutAwarePage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        string tempText;
        int groesse;

        /// <summary>
        /// Füllt die Seite mit Inhalt auf, der bei der Navigation übergeben wird. Gespeicherte Zustände werden ebenfalls
        /// bereitgestellt, wenn eine Seite aus einer vorherigen Sitzung neu erstellt wird.
        /// </summary>
        /// <param name="navigationParameter">Der Parameterwert, der an
        /// <see cref="Frame.Navigate(Type, Object)"/> übergeben wurde, als diese Seite ursprünglich angefordert wurde.
        /// </param>
        /// <param name="pageState">Ein Wörterbuch des Zustands, der von dieser Seite während einer früheren Sitzung
        /// beibehalten wurde. Beim ersten Aufrufen einer Seite ist dieser Wert NULL.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            if (pageState != null)
            {
                if (pageState.ContainsKey("eingabe"))
                {
                    eingabe.Text = pageState["eingabe"].ToString();
                }
                if (pageState.ContainsKey("groeße"))
                {
                    eingabe.FontSize = Convert.ToInt32(pageState["groeße"].ToString());
                }
            }
        }

        /// <summary>
        /// Behält den dieser Seite zugeordneten Zustand bei, wenn die Anwendung angehalten oder
        /// die Seite im Navigationscache verworfen wird. Die Werte müssen den Serialisierungsanforderungen
        /// von <see cref="SuspensionManager.SessionState"/> entsprechen.
        /// </summary>
        /// <param name="pageState">Ein leeres Wörterbuch, das mit dem serialisierbaren Zustand aufgefüllt wird.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
            pageState["eingabe"] = eingabe.Text;
            pageState["groeße"] = eingabe.FontSize;
        }

        private void eingabe_GotFocus(object sender, RoutedEventArgs e)
        {
            eingabe.Text = tempText;
            eingabe.FontSize = groesse;
        }

        private void Button_Click_Groesser(object sender, RoutedEventArgs e)
        {
            if(eingabe.FontSize < 41)
                wachstum(+1);
        }

        private void wachstum(int groesser)
        {
            eingabe.FontSize = eingabe.FontSize + groesser;
        }
        private void Button_CLick_Kleiner(object sender, RoutedEventArgs e)
        {
            if(eingabe.FontSize > 9)
            schrumpfen(+1);
        }

        private void schrumpfen(int kleiner)
        {
            eingabe.FontSize = eingabe.FontSize - kleiner;
        }
    }
}
