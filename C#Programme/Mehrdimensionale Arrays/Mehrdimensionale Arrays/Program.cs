using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehrdimensionale_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //ein Array mit 2 Dimensionen und direkter Zuweisung
            int[,] tabellenArray1 = { { 3, 5, 7, 6 }, { 2, 1, 0, 9 } };

            //noch ein Array mit 2 Dimensionen
            int[,] tabellenArray2 = new int[3, 3];

            //die Daten im ersten Array ausgeben
            foreach (int element in tabellenArray1)
                Console.WriteLine("Der Wert ist {0}", element);
            Console.Write("\n");

            //einem Element im zweiten Array einen Wert zuweisen
            tabellenArray2[1, 1] = 10;
            //die Daten im zweiten Array ausgeben
            foreach (int element in tabellenArray2)
                Console.WriteLine("Der Wert ist {0}", element);
        }
    }
}
