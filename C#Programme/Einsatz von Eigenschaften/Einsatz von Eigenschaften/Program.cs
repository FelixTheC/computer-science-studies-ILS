using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Einsatz_von_Eigenschaften
{
    class Esel
    {
        private int sturheit;
        private int gewicht;

        //die Eigenschaften
        public int gewichtInGramm
        {
            //die get() Methode
            get
            {
                return gewicht * 1000;
            }
            //die set() Methode
            //value steht für den Wert, der übergeben wird
            set
            {
                gewicht = value / 1000;
            }
        }
        //die öffentlichen Methoden
        public void Arbeiten()
        {
            if(sturheit > 9 || gewicht < 10)
            {
                Console.WriteLine("Der Esel kann nicht mehr arbeiten");
            }
            else
            {
                sturheit++;
                gewicht--;
                Console.WriteLine("Der Esel hat gearbeitet");
            }
        }
        public void Fressen()
        {
            gewicht++;
            if(sturheit> 0)
            {
                sturheit--;
            }
            Console.WriteLine("Der Esel hat gefressen");
        }
        public int Wiegen()
        {
            return gewicht;
        }
        public void Init()
        {
            gewicht = 15;
            sturheit = 10;
        }
        
   }
    class Program
    {
        static void Main(string[] args)
        {
            Esel eselchen = new Esel();
            eselchen.Init();
            eselchen.Arbeiten();
            eselchen.Fressen();

            Console.WriteLine("Der Esel wiegt {0} Kilo", eselchen.Wiegen());

            //die Eigenschaft gewichtInGramm
            Console.WriteLine("Der Esel wiegt {0} Gramm", eselchen.gewichtInGramm);

            //die Eigenschaft gewichtInGramm setzen
            eselchen.gewichtInGramm = 10000;

            //dadurch verändert sich auch das Gewicht
            Console.WriteLine("Der Esel wiegt {0}", eselchen.gewichtInGramm);
            Console.WriteLine("Der Esel wiegt {0} Kilo", eselchen.Wiegen());
        }
    }
}
