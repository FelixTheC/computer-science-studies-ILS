using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonderfunktion_von_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //die Verinbarung des ersten Arrays mit 5 Elementen
            int[] zahlenArray1 = new int[5];
            //ein zweites hat nur ein Element
            int[] zahlenArray2 = new int[1];

            //zwei int-Variablen für die Suche
            int suche, treffer;

            //werte in das erste Array einlesen
            for (Int32 element = 0; element < zahlenArray1.Length; element++)
            {
                Console.WriteLine("Bitte geben Sie einen Wert ein:");
                zahlenArray1[element] = Convert.ToInt32(Console.ReadLine());
            }

            //das erste Array wird komplett in das zweite kopiert
            zahlenArray2 = (int[])zahlenArray1.Clone();

            //jetzt wird das zweite Array sortiert und dann ausgegeben
            Array.Sort(zahlenArray2);
            Console.WriteLine("Die sortierte Ausgabe...");
            foreach (int element in zahlenArray2)
                Console.Write("{0}", element);

            Console.WriteLine("Nach welcher Zahle soll gesucht werden? ");
            suche = Convert.ToInt32(Console.ReadLine());

            //die Suche
            treffer = Array.BinarySearch(zahlenArray2, suche);
            //wurde etwas gefunden
            if (treffer < 0)
                Console.WriteLine("Die Suche ergab keinen Treffer");
            else
                Console.WriteLine("Das Element {0} befindet sich an der Position {1}.", suche, treffer);
            // an zahlenArray1 hat sich nichts verändert
            foreach (int element in zahlenArray1)
                Console.WriteLine("{0}", element);

            Console.WriteLine();
        }
    }
}
