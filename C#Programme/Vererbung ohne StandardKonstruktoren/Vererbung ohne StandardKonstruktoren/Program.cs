using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung_ohne_StandardKonstruktoren
{
    //eine Klasse Bär erstellen
    class Baer
    {   //die Felder
        int gewicht;
        int alter;

        //ein eigener Konstruktor für Baer
        public Baer(int gewicht, int alter)
        {
            this.gewicht = gewicht;
            this.alter = alter;
        }
        //diese Methode gibt das Gewichtzurück
        public int GetGewicht()
        {
            return gewicht;
        }
        //diese Methode gibt das alter zurück
        public int GetAlter()
        {
            return alter;
        }

        //die Klasse Elternbär erbt von der Klasse Bär
        class ElternBaer : Baer
        {
            //eigene Felder
            int anzahlKinder;

            //der Konstruktor für Elternbaer mit hilfe von base
            public ElternBaer(int gewicht, int alter, int anzahlKinder) : base(gewicht,alter)
            {
                this.anzahlKinder = anzahlKinder;
            }
            //diese Methode liefert die anzahl der Kinder zurück
            public int GetKinder()
            {
                return anzahlKinder;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //einen Bär erzeugen
            Baer alterBaer = new Baer(200, 10);
            //einen Papabär erzeugen
            ElternBaer papaBaer = new ElternBaer(500, 5, 20);

            Console.WriteLine("Der alter Bär ist {0} Jahre alt und wiegt {1} Kilo", alterBaer.GetAlter(), alterBaer.GetGewicht());
            Console.WriteLine("Papabär ist {0} Jahre alt, wiegt {1} Kilo und hat {2} Kinder", papaBaer.GetAlter(), papaBaer.GetGewicht(),papaBaer.GetKinder());
        }
    }
}
