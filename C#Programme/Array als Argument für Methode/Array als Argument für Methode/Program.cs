using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_als_Argument_für_Methode
{
    class Program
    {
        static void eingabe(int[] argArray)
        {
            //das einlesen in das Array
            for (int index =0; index < argArray.Length;index++)
            {
                Console.Write("Bitte geben Sie {0} Zahl ein:", index + 1);
                argArray[index] = Convert.ToInt32(Console.ReadLine());
            } 
        }
            static void Quadrat(int[] argArray)
            {
                foreach(int element in argArray)
                    Console.WriteLine("Das Quadrat von {0} ist {1}", element, element*element);
            }
        
        static void Main(string[] args)
        {
        //die Vereinbarung des Array
    int[]zahlenArray = new int[5];
        //das Einlesen in einer Methode
    eingabe(zahlenArray);
    //das Berechnen und die Ausgabe über eine Methode
    Quadrat(zahlenArray);
        }
    }
}
