/*##################################
 
Einsendeaufgabe 2.4
  
 #################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHB_2B2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Stunden = 24;
            const int Minuten = 60;

            Console.WriteLine("Eine Stunde hat {0} Minuten ",Minuten);
            Console.WriteLine("Ein Tag hat {0} Minuten", Stunden*Minuten);
            Console.WriteLine("Eine Woche hat {0} Minuten", Stunden*Minuten * 7);


        }
    }
}
