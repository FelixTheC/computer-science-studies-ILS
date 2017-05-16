/*##################################
Einsendeaufgabe 3.3
 #################################*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP_3B3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 1;
            int zahl2 = 1;
            while (zahl <= 50)
            {
                zahl2 = zahl * 2;
                Console.Write("{0}={1} \n", zahl, zahl2);
                zahl++;
            }
            
        }
    }
}
