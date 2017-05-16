using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eingabe_mit_Konvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            char eingabe1;
            int eingabe2, eingabe3;

            Console.WriteLine("Geben Sie ein Zeichen ein. Drücken Sie dann die Eingabetaste");
            eingabe1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Sie haben das Zeichen {0} eingegeben.", eingabe1);

            //Zahl einlesen
            Console.WriteLine("Geben Sie bitte die erste Zahl ein. Und drücken Sie die Eingabetaste.");
                eingabe2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Geben Sie bitte die zweite Zahl ein. Und drücken Sie die Eingabetaste.");
                eingabe3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Die Addition der Zahlen {0} und {1} ergibt = {2}", eingabe2, eingabe3, eingabe2 + eingabe3);
        }
    }
}
