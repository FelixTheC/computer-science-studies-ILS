using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mit_KMethodenUKVariablen
{
    //die selbst erstellte Klasse
    class Potenz
    {
        //eine Klassenvariable
        static int ergebnis;

        //eine Klassenmethode
        public static int Berechnen(int wert)
        {
            ergebnis = wert * wert;
            return ergebnis;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //der Aufruf der Klassenmethode aus Potenz

            Console.WriteLine("Die Potenz von 4 ist {0}", Potenz.Berechnen(4));
        }
    }
}
