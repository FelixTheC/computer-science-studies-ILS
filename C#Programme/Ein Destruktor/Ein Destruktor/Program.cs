using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ein_Destruktor
{
    //die Klasse Sherry
    class Sherry
    {
        //die Felder
        int alter;
        int liter;

        //die Methoden
        //der Konstruktor
        public Sherry(int alter, int liter)
        {
            this.alter = alter;
            this.liter = liter;
        }
        //zum Ansehen
        public void Ansehen()
        {
            Console.WriteLine("Der Sherry ist {0} Jahre alt", alter);
            Console.WriteLine("Die Flasche enthält {0} Liter", liter);
        }

        //der Destruktor
        ~Sherry()
        {
            Console.WriteLine("Eine Instanz von {0} wurde zerstört", this.GetType());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //eine Instanz erzeugen und Werte mit Konstruktor übergeben
            Sherry flasche1 = new Sherry(20, 1);

            //die Werte ausgeben
            flasche1.Ansehen();

            //flasche1 auf null setzen, damit sie vom Garbage Collector aufgeräumt wird

            flasche1 = null;

            //den Garbage Collector per Hand aufrufen
            GC.Collect();
        }
    }
}
