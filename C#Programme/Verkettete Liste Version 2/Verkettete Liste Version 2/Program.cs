using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkettete_Liste_Version_2
{
    //die Klasse für die Listenelement
    //jetzt auch mit Methoden
    class Listenelement
    {
        string daten;
        //Referenz auf die Klasse selbst
        Listenelement naechster;

        //die Methode zum setzen der Daten
        public void SetDaten(string datenNeu)
        {
            //die Zeichenkette setzen
            daten = datenNeu;
            //das Ende markieren
            naechster = null;
        }
        //die Methode zum Anhängen eines neuen Elementes
        //diese ruft sich rekursiv auf, bis das Ende erreicht ist
        public void Anhaengen(string datenNeu)
        {
            if (naechster == null)
            {
                naechster = new Listenelement();
                naechster.SetDaten(datenNeu);
            }
            //sonst ruft sich die Methode selber wieder auf
            else
                naechster.Anhaengen(datenNeu);
                Console.WriteLine("Daten {0} wurden eingefügt", datenNeu);
        }
            //die Methode zur Ausgabe der Liste
            //diese ruft sich ebenfalls rekursiv auf, bis das Listenende erreicht wurde
            public void Ausgeben()
        {
            Console.WriteLine(daten);
                if(naechster != null)
                {
                    naechster.Ausgeben();
                }
        }
        }
    
    class Program
    {
        static void Main(string[] args)
        {
            //ein neues Listenelement erzeugen
            Listenelement listenAnfang = new Listenelement();

            //die Daten im ersten Listenelement setzen
            listenAnfang.SetDaten("Element 1");

            //weitere Elemente über eine Schleife einfügen
            for (int element = 2; element < 10; element++)
            {
                listenAnfang.Anhaengen("Element " + element);

                //die Liste ausgeben
                listenAnfang.Ausgeben();
            }
        }
    }
}
