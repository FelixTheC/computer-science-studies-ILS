using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Der_Konstruktor
{
    class Sherry
    {
        int alter;
        int liter;
        //die Methoden
        //der Konstruktor
        public Sherry(int alter, int liter)
        {
            this.alter = alter;
            this.liter = liter;
        }
        public void Ansehen()
        {
            Console.WriteLine("Der Sherry ist {0} Jahre alt", alter);
            Console.WriteLine("Der Sherry hat {0} liter", liter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instanz erzeugen
            //dabei werden der neuen Instanz die Werte via Konstruktor gesetzt
            Sherry flasche1 = new Sherry(10,1);
            //werte ausgeben
            flasche1.Ansehen();
        }
    }
}
