using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einführung_in_Klassen
{
    //die Vereinbarung der Klassen Autoklasse
    //Sie erfolgt ausserhalb der Klasse für das Programm
    class Autoklasse
    {
        //ein Feld
        int geschwindigkeit;
        
        //die Methoden zum Initialisieren
        public void Initialisieren(int standard)
        {
            geschwindigkeit = standard;
        }
        //zum Bremsen
        public void Bremsen(int aenderung)
        {
            if(geschwindigkeit - aenderung < 0)
            {
                geschwindigkeit = 0;
            }
            else
            {
                geschwindigkeit = geschwindigkeit - aenderung;
            }
        }
        //zum Gasgeben
        public void Gasgeben(int aenderung)
        {
            geschwindigkeit = geschwindigkeit + aenderung;
        }
        //zur Ausgabe der Geschwindigkeit
        public void Ausgeben()
        {
            Console.WriteLine("Die aktuelle Geschwindigkeit beträgt {0}", geschwindigkeit);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //zwei neue Instanzen für Autoklasse erzeugen
            Autoklasse auto1 = new Autoklasse();
            Autoklasse auto2 = new Autoklasse();

            //die Methode Inistialisiere() für die beiden Autos aufrufen

            auto1.Initialisieren(0);
            auto2.Initialisieren(10);

            //die Geschwindigkeit ausgeben
            Console.WriteLine("Nach der Inistialisierung");
            auto1.Ausgeben();
            auto2.Ausgeben();

            //Methode Gasgeben() aufrufen
            auto1.Gasgeben(20);
            auto2.Gasgeben(100);

            Console.WriteLine("Nach Gasgeben");
            auto1.Ausgeben();
            auto2.Ausgeben();

            //Methode Bremsen() aufrufen

            auto1.Bremsen(10);
            auto2.Bremsen(50);

            Console.WriteLine("Nach Bremsen");
            auto1.Ausgeben();
            auto2.Ausgeben();
        }
    }
}
