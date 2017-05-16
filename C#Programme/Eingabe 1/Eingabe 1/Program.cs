using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eingabe_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung der Variablen
            int eingabe1;
            string eingabe2, eingabe3;
            //ein Zeichen über Read() lesen und ausgeben
            Console.WriteLine("Geben Sie ein Zeichen ein. Drücken Sie dann die Eingabetaste.");
            eingabe1 = Console.Read();

            Console.WriteLine("Sie haben das Zeichen {0} eingegeben.", eingabe1);
            //die Eingabetaste aus dem Puffer holen
            //sonst wird die nächste Eingabe scheinbar übersprungen
            Console.ReadLine();

            //Zahlen einlesen
            Console.WriteLine("Geben Sie bitte die erste Zahl ein. Drücken Sie dann die Eingabetaste.");
            eingabe2 = Console.ReadLine();

            Console.WriteLine("Geben Sie bitte die zweite Zahl ein. Drücken Sie dann die Eingabetaste.");
            eingabe3 = Console.ReadLine();

            Console.WriteLine("Die Addition der Zahlen {0} und {1} ergibt = {2}", eingabe2, eingabe3, eingabe2 + eingabe3);
            //Zeichenkette einlesen
            Console.WriteLine("Wie heißen Sie?");
            eingabe2 = Console.ReadLine();
            Console.WriteLine("Wenn wollen Sie grüßen??");
            eingabe3 = Console.ReadLine();
            Console.WriteLine("Hallo {0}. Es grüßt Dich {1}", eingabe3, eingabe2);
        }
    }
}
