using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkettete_Liste_Version1
{
    //eine Klasse für die Listenelemente
    //Sie entählt nur Felder für die Daten und den Nachfolger, aber keine Methoden

    class Listenelement
    {
        public string Daten;
        public Listenelement Naechster;
    }

    class Program
    {
        //Klassenmethoden für die Verarbeitung der Liste
        //die Daten für ein Element setzen
        //Übergeben werden die Zeichenkette und das Element der Liste

        static void SetDaten(String datenNeu, Listenelement element)
        {
            //die Zeichenkette setzen
            element.Daten = datenNeu;
            //das Ende markieren
            element.Naechster = null;
        }
        //ein neues Element am Ende der Liste einfügen
        //Übergeben werden die Zeichenkette und der Listenanfang
        //das eigentliche Einfügen erfolgt über die Methode 
        //SetDaten()

        static void ListeAnhaengen(string datenNeu, Listenelement listenAnfang)
        {
            //eine Hilfskonstruktion zum Wandern in der Liste
            Listenelement hilfsKonstruktion;
            hilfsKonstruktion = listenAnfang;

            //durch die Liste gehen, bis das Ende erreicht ist
            while (hilfsKonstruktion.Naechster != null)
            {
                hilfsKonstruktion = hilfsKonstruktion.Naechster;

                //neues Element am Ende der Liste einfügen
                hilfsKonstruktion.Naechster = new Listenelement();

                //Hilfskonstruktion auf das neue Element setzen

                hilfsKonstruktion = hilfsKonstruktion.Naechster;

                //die Daten eintragen
                SetDaten(datenNeu, hilfsKonstruktion);
            }
        }
            //die Ausgabe der kompletten Liste
            static void ListeAusgeben(Listenelement listenAnfang)
            {
                //die Hilfskonstruktion
                Listenelement hilfskonstruktion;
                hilfskonstruktion = listenAnfang;
                //erstes Element ausgeben
                Console.WriteLine(hilfskonstruktion.Daten);
                //und nun den Rest
                while (hilfskonstruktion.Naechster != null)
                {
                    hilfskonstruktion = hilfskonstruktion.Naechster;
                    Console.WriteLine(hilfskonstruktion.Daten);
                }
            }
        
        static void Main(string[] args)
        {
    //ein neues Listenelement erzeugen
    Listenelement listenAnfang = new Listenelement();
    //die Daten im ersten Listenelement setzen
    SetDaten("Element1",listenAnfang);
    //weiter Elemente in einer Schleife anfügen
    for (int element = 2; element < 10; element++)
{
    ListeAnhaengen("Element "+ element, listenAnfang);

    //die Liste ausgeben
        ListeAusgeben(listenAnfang);
}
        }
    }
}
