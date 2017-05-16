using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debuggen1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zaehler = 1;
            
            while(zaehler <= 10)
            {
                Console.WriteLine("Schleifendurchlauf Numer {0}", zaehler);
                    zaehler ++;
            }
        }
    }
}
