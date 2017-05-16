using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeichenweise_Ausgabe_von_Zeichenketten
{
    class Program
    {
        static void Main(string[] args)
        {
            //vereinbarung
            string zKette1;
            string zKette2;
            string zKette3;
            //die Zeichenketten enthalten Werte
            zKette1 = "Ich bin";
            zKette2 = " eine Zeichenkette";
            //hier werden die Zeichenketten verbunden
            zKette3 = zKette1 + zKette2;
            //die Ausgabe der Länge
            Console.WriteLine("Die Zeichenkette enthält {0} Zeichen", zKette3.Length);

            //"normale" Ausgabe mit for und der Länge
            for (int index = 0; index < zKette3.Length; index++)
                Console.Write("{0}", zKette3[index]);

            Console.WriteLine();

            //Ausgabe über for each
            foreach (char zeichen in zKette3)
                Console.Write("{0}", zeichen);

            Console.WriteLine();

        }
    }
}
