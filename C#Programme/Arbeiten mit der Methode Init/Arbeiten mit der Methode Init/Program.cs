using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeiten_mit_der_Methode_Init
{
    //die Klasse Sherry
    class Sherry
    {
        //die Felder
        int alter;  //privat da nicht anders Vereinbart
        int liter;

        //die Methode
        //zur Initialisierung
        //die Felder werden über this angesprochen
        public void Init(int alter, int liter)
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instanz flasche1 erzeugen
            Sherry flasche1 = new Sherry();

            //die Felder initialisieren
            flasche1.Init(10, 1);

            //die Werte ausgeben
            flasche1.Ansehen();
        }
    }
}
