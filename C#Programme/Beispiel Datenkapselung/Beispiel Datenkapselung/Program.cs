using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel_Datenkapselung
{   //die Klasse Esel
    class Esel
    {
        //die privaten Felder
        private int sturheit;
        private int gewicht;

        //die öffentlichen Felder
        public void Arbeiten()
    {
        if (sturheit > 9 || gewicht < 10)
        Console.WriteLine("Der Esel kann nicht arbeiten");
        else
    {
        sturheit++;
        gewicht--;
        Console.WriteLine("Der Esel hat jetzt gearbeitet");
    }
    }
    public void fressen()
        {
            gewicht++;
        if(sturheit > 0)
        {
            sturheit--;
        }
        Console.WriteLine("Der Esel hat jetzt gefressen");
        }
        public int wiegen()
    {
        return gewicht;
    }
        public void Init()
        {
            sturheit = 5;
            gewicht = 15;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Instanz Eselchen erzeugen
            Esel eselchen = new Esel();
            //die Methoden aufrufen
            eselchen.Init();
            eselchen.Arbeiten();
            eselchen.fressen();
            Console.WriteLine("Der Esel wiegt jetzt {0} Kilo", eselchen.wiegen());
        }
    }
}
