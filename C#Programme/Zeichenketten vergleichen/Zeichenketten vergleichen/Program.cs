using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeichenketten_vergleichen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung
            string zKette2;
            string zKette1 = "Rätsel";
            //die zweite Zeichenkette einlesen
            do
            {
                Console.WriteLine("Raten Sie. Wie heißt das Wort? ");
                zKette2 = Console.ReadLine();
            } while (zKette2 == String.Empty);

            //die beiden Zeichenketten vergleichen
            if (zKette1 == zKette2)
                Console.WriteLine("Sie haben Richtig geraten");
            else
                Console.WriteLine("Leider Falsch geraten");
        }
    }
}
