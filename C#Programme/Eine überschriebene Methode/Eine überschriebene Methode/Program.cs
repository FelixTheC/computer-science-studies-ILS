using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eine_überschriebene_Methode
{
    //die Basisklasse Bär
    class Baer
    {
        //beide Felder müssen als Protected vereinbart werden
        protected int gewicht;
        protected int alter;
        
        public Baer(int gewicht, int alter)
        {
            this.gewicht = gewicht;
            this.alter = alter;
        }
        public int GetGewicht()
        {
            return gewicht;
        }
        public int GetAlter()
        {
            return alter;
        }
        //eine Methode zum Ausgeben
        public void Ausgeben()
        {
            Console.WriteLine("Die Ausgabe erfolgt aus {0}", this.GetType());
            Console.WriteLine("Der Bär ist {0} Jahre alt und wiegt {1} Kilo", alter, gewicht);
        }
      }
    //die Klasse Elternbär erbt von Bär
    class ElternBaer : Baer
    {
        int anzahlKinder;
        //ein eigener Konstruktor er ruft den Konstruktor der Basisklasse über base auf
        public ElternBaer(int gewicht, int alter, int anzahlKinder) : base (gewicht,alter)
        {
            this.anzahlKinder = anzahlKinder;
        }
       public int GetAnzahlKinder()
        {
            return anzahlKinder;
        }
        //die Methode zur Ausgabe der Werte
        //Sie "überschreibt" die gleichnamige Methode der Basisklasse
        public void Ausgeben()
       {
           Console.WriteLine("Die Ausgabe erfolgt aus {0}", this.GetType());
           Console.WriteLine("Der Bär ist {0} Jahre alt, wiegt {1} Kilo und hat {2} Kinder", alter, gewicht, anzahlKinder);
       }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Baer[] Baerenliste = new Baer[2];
            Baerenliste[0] = new Baer(200, 3);
            Baerenliste[1] = new ElternBaer(500, 5, 20);

            foreach (Baer testBaer in Baerenliste)
                testBaer.Ausgeben();
        }
    }
}
