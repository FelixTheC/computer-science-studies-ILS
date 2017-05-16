using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behälter
{
    //die Klasse für die Behälter
    class Behaelter
    {
        //die Felder
        int fuellstand;
        Behaelter andererBehaelter;

        //die Methoden
        public void Init(int menge)
        {
            fuellstand = menge;
        }

        public void VerbindenMit(Behaelter behaelter)
        {
            andererBehaelter = behaelter;
        }
        public int GetFuellstand()
        {
            return fuellstand;
        }
        public int Aufnehmen(int menge)
        {
            int rueckgabe;
            if (menge + fuellstand > 100)
            {
                rueckgabe = 100 - fuellstand;
                fuellstand = 100;
            }
            else
            {
                fuellstand = fuellstand + menge;
                rueckgabe = menge;
            }
            return rueckgabe;
        }
        public void Abgeben(int menge)
        {
            int gepumpt;
            if (menge > fuellstand)
                gepumpt = andererBehaelter.Aufnehmen(fuellstand);
            else
                gepumpt = andererBehaelter.Aufnehmen(menge);
            fuellstand = fuellstand - gepumpt;
        }
    }
    class Program
    {
             //Ausgabe() ist eine Klassenmethode für die Klasse des Programms
            static void Ausgabe(Behaelter behaelter1, Behaelter behaelter2)
            {
                Console.WriteLine("Behälter1 ------------------ Behälter2");
                Console.Write(behaelter1.GetFuellstand());
                Console.Write ("           -----------");
                Console.Write(behaelter2.GetFuellstand());
            }
    
        static void Main(string[] args)
        {
             //die Instanzen erzeugen und initialisieren
                Behaelter behaelter1 = new Behaelter();
                Behaelter behaelter2 = new Behaelter();
                
                behaelter1.Init(60);
                behaelter2.Init(60);

               //die "Leitungen" zwischen den Behältern legen
                behaelter1.VerbindenMit(behaelter2);
                behaelter2.VerbindenMit(behaelter1);

               //Ausgabe der Füllstände über die Klassenmethode
                Ausgabe(behaelter1, behaelter2);

               //10 Liter aus Behälter 1 umpumpen
                behaelter1.Abgeben(10);
                Ausgabe(behaelter1, behaelter2);

               //mehr umpumpen als passt
                behaelter1.Abgeben(40);
                Ausgabe(behaelter1, behaelter2);

               //60 Liter aus Behälter 2 umpumpen
                behaelter2.Abgeben(60);
                Ausgabe(behaelter1, behaelter2);
    
            }
        
    }
}
