using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eine_unechte_kopie_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aArray;
            int[] bArray = new int[5];

            //bArray mit Werten füllen
            for (int element = 0; element < bArray.Length; element++)
                bArray[element] = 5 * element;

            //die Kopie erstellen
            aArray = bArray;
            //die Werte zur Kontrolle ausgeben
            Console.WriteLine("Die Werte in aArray sind:");
            foreach (int element in aArray) 
            Console.WriteLine("{0}", element);
            Console.WriteLine("Die Werte von bArray sind:");
            foreach (int element in bArray)
                Console.WriteLine("{0}", element);

            //je einen Wert verändern
            aArray[0] = 200;
            bArray[4] = 1000;
             //die Änderungerfolgt in beiden Arrays
            Console.WriteLine("Die Werte von aArray sind:");
            foreach (int element in aArray)
                Console.WriteLine("{0}", element);
            Console.WriteLine("Die Werte von bArray sind:");
            foreach (int element in bArray)
                Console.WriteLine("{0}", element);
        }
    }
}
