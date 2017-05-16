using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel_für_ein_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //die Vereinbarung des Array
            int[] zahlen = new int[5];

            //das Einlesen in das Array
            for (int index =0; index < 5; index++)
            {
                Console.Write("Bitte geben Sie die {0}. Zahl ein: ", index + 1);
                zahlen[index] = Convert.ToInt32(Console.ReadLine());
            }
            //die Berechnung und die Ausgabe
            for (int index = 0; index < 5; index++)
                Console.WriteLine("Das Quadrat von {0} ist: {1}", zahlen[index], zahlen[index] * zahlen[index]);
        }
    }
}
