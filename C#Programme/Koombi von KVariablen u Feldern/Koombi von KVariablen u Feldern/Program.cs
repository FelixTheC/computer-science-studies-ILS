using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koombi_von_KVariablen_u_Feldern
{
    //Vereinbarung der Klasse Autoklasse
    class Autoklasse
    {
        //die Klassenvariable
        static int autoZaehler;
        //das Feld
        int geschwindigkeit;

        //die Methoden

        //eine Klassenmethode, die die Anzahl der Instanzen liefert
        public static int getautoZaehler()
        {
            return autoZaehler;
        }
        //die "echten" Methoden
        //hier wird jetzt auch die Klassenvariable
        //autoZaehler um den Wert 1 erhöht
        public void Initialisiere(int standard)
        {
            int geschwindigkeit = standard;
            autoZaehler++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //zwei neue Instanzen für Autoklasse erzeugen
            Autoklasse auto1 = new Autoklasse();
            Autoklasse auto2 = new Autoklasse();

            //die Methode Initialisieren() für beide Autos aufrufen

            auto1.Initialisiere(0);
            auto2.Initialisiere(10);

            //die Anzahl der Autos über die Klassenmethode ausgeben
            Console.WriteLine("Es gibt {0} Autos", Autoklasse.getautoZaehler());
        }
    }
}
