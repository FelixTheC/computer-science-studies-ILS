/*#############################################
 Einsendeaufgabe 5.2
 ############################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Einfache_Liste_2
{
    class Program
    {   //die Klasse für die Listenelemente
        public class Listenelement
        {
            private string daten;
            Listenelement naechster;

            public void SetDaten(string datenNeu)
            {   //die Zeichenkette setzen
                daten = datenNeu;
                //das Ende markieren
                naechster = null;
            }
            //die Methode zum Anhängen eines neuen Elements
            //sie ruft sich rekursiv auf und gibt das aktuelle Ende immer wieder zurück
            public Listenelement Anhaengen(string datenNeu)
            {
                if (naechster == null)
                {
                    naechster = new Listenelement();
                    naechster.SetDaten(datenNeu);
                }
                else
                {
                    return naechster.Anhaengen(datenNeu);
                }
                return this.naechster;
                Console.WriteLine("Hallo {0}", datenNeu);
            }
            //die Methode zur Ausgabe der Liste
            public void Ausgeben()
            {
                Console.WriteLine(daten);
                if (naechster != null)
                    naechster.Ausgeben();
            }
        }

        static void Main(string[] args)
        {   //ein Listenelement mit dem Anfang und dem Ende erstellen
            Listenelement listenAnfang = new Listenelement();
            Listenelement listenEnde = new Listenelement();
            
            //die Daten im ersten Listenelement setzen
            listenAnfang.SetDaten("Element 1");
           
            //weiter Elemente in einer Schleife hinzufügen
            for (int element = 2; element <= 10; element++)
            {   //das Ende ist das Ende aber gleichzeitig auch der Anfang
                listenEnde = listenAnfang.Anhaengen("Element " + element);
            }
           
            //die Liste ausgeben
            listenAnfang.Ausgeben();
            

        }
    }
}