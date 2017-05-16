using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_der_Überdeckung
{
    class Ueberdeckt
    {
        //das Feld
        string zeichenkette;
        //die Methode soll den Wert zeichenkette ändern
        public void ZeichenketteAendern(string zeichenkette)
        {
           this.zeichenkette = zeichenkette + " geändert";
        }
        //die Zeichenkette liefern
        public string GetZeichenkette()
        {
            return zeichenkette;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //eine Instanz von Ueberdeckt erzeugen
            Ueberdeckt test = new Ueberdeckt();
            test.ZeichenketteAendern("Test");
            //das führt zu seltsamen Ausgaben
            Console.WriteLine("Der geänderte Wert ist {0}.", test.GetZeichenkette());
            //und das ebenfalls
            if (test.GetZeichenkette()== String.Empty)
            {
                Console.WriteLine("Die Zeichenkette ist leer");
            }
            else
            {
                Console.WriteLine("Die Zeichenkette ist nicht leer");
            }
        }
    }
}
