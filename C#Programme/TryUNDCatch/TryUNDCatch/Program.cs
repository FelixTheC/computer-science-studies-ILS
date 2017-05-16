using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryUNDCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1, zahl2, ergebnis;

            Console.Write("Zahl 1: ");
            zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            zahl2 = Convert.ToInt32(Console.ReadLine());

            //die Division wird versucht
            try
            {
                ergebnis = zahl1 / zahl2;
            }
            catch
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
                Console.WriteLine("Ergebnis erhält den Wert 0.");
                ergebnis = 0;
            }
            Console.WriteLine("Das Ergebnis ist {0}",ergebnis);
        }
    }
}
