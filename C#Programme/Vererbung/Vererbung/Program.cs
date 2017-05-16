using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{   //die Basisklasse Baer
    class Baer
    {
        //die Felder
        int gewicht;
        int alter;
        
        //der Standard-Konstruktor
        public Baer()
        {
            gewicht = 100;
            alter = 5;
        }
        //diese Methode liefert das Gewicht
        public int GetGewicht()
        {
            return gewicht; 
        }

        //diese Methode liefert das Alter
        public int GetAlter()
        {
            return alter;
        }
    }
    //die Klasse Elternbaer erbt von Baer
    class Elternbaer:Baer
    {
        //eigene Felder für Elternbaer erstellen
        int anzahlKinder;

        //der Standard-Konstruktor für Elternbaer
        public Elternbaer()
        {
            anzahlKinder = 2; 
        }

        //die Methode liefert die Anzahl der Kinder
        public int GetKinder()
        {
            return anzahlKinder;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //einen Bär mit dem Standard-Konstruktor erstelle
            Baer alterBaer = new Baer();
 
            //einen Papabär mit seinem Standard-Konstruktor erstellen
            Elternbaer papaBaer = new Elternbaer();

            //Werte über die jeweilige Methoden anzeigen
            Console.WriteLine("Der alte Bär ist {0} Jahre alt und Wiegt {1} Kilo", alterBaer.GetAlter(), alterBaer.GetGewicht());
            Console.WriteLine("Der Papabär ist {0} Jahre alt und Wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(), papaBaer.GetKinder());
        }
    }
}
