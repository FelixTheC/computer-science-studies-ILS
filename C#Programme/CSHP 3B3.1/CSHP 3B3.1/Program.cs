/*############################################
 Einsendeaufgabe 3.1
 ###########################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP_3B3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int JahresZahl;
            Console.WriteLine("Bitte geben Sie eine Jahreszahl ein.");
            JahresZahl = Convert.ToInt16(Console.ReadLine());
            if ((JahresZahl % 4 == 0) && (JahresZahl % 400 == 0) || (JahresZahl % 100 != 0))
                Console.WriteLine("{0} ist ein Schaltjahr", JahresZahl);
            else
                Console.WriteLine("{0} ist kein Schaltjahr", JahresZahl);

                
        }
    }
}
