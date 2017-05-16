using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicherer_Zugriff__Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[10];
            //Zuweisung über eine Schleife und die Eigenschaft Length
            for (int element = 0; element < zahlen.Length; element++)
                zahlen[element] = element * element;

            //Ausgabe über eine foreach-Schleife
            foreach (int element in zahlen)
                Console.WriteLine("Der Wert ist {0}", element);
        }
    }
}
