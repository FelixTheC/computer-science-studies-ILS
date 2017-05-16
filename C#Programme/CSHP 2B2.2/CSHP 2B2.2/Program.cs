/*##################################
 
Einsendeaufgabe 2.2
 
 #################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP_2B2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe1, eingabe2;
            double var3;
            Console.WriteLine("Bitte geben Sie Ihre erste Zahl ein. Und drücken Sie die Eingabetaste!");
            eingabe1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie jetzt Ihre zweite Zahl ein. Und drücken Sie die Eingabetaste!");
            eingabe2 = Convert.ToInt32(Console.ReadLine());
            var3 = eingabe1 / (double)eingabe2;
            Console.WriteLine("Das Ergebnis der Division von {0} und {1} = {2}", eingabe1, eingabe2, var3);

        }
    }
}
