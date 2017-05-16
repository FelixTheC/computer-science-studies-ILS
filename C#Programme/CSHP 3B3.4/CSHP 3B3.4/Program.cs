/*########################################
 Einsendeaufgabe 3.4
 #######################################*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP_3B3._4
{
    class Program
    {
        static double addition(double eingabeA, double eingabeB)
    {
        return (eingabeA + eingabeB);
     
    }
        static double substraktion(double eingabeA, double eingabeB)
        {
            return (eingabeA - eingabeB);
        }
        static double multiplikation(double eingabeA, double eingabeB)
        {
            return (eingabeA * eingabeB);
        }
        static double division(double eingabeA, double eingabeB)
        {
            return (eingabeA / eingabeB);
        }
        static double potenz(double eingabeA, double eingabeB)
        {
            double summe;
            summe = 1;
            do
            {
                summe = summe * eingabeA;
                eingabeB--;
            } while (eingabeB != 0);

                return summe;
                 
        }

        static void Main(string[] args)
        {
            double eingabeA, eingabeB;
            char Auswahl;
            Console.WriteLine("Bitte geben Sie ihre erste Zahl ein oder die Basis");
            eingabeA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie ihre zweite Zahl ein oder ihren Exponenten");
            eingabeB = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Was möchten Sie mit diesen Zahlen machen?? \n\nDrücken Sie \n'A' für Addition 'S' für Substraktion \n'M' für Mulitiplikation 'D' für Division\n'P' für Potenzrechnung\n");
            Console.WriteLine("Bestätigen Sie ihre Eingabe mit der Entertaste");
            Auswahl = Convert.ToChar(Console.ReadLine());
            switch (Auswahl){
                
                case'a':
                case'A':
                Console.WriteLine("Ihr Ergebnis lautet {0}\n", addition(eingabeA, eingabeB));
                break;
                case's':
                case'S':
                    Console.WriteLine("Ihr Ergebnis lautet {0}\n", substraktion(eingabeA, eingabeB));
                    break;
                case'd':
                case'D':
                    Console.WriteLine("Ihre Ergebnis lautet {0}\n", division(eingabeA, eingabeB));
                    break;
                case'm':
                case'M':
                    Console.WriteLine("Ihr Ergebnis lautet {0}\n", multiplikation(eingabeA, eingabeB));
                    break;
                case 'p':
                case 'P':
                    Console.WriteLine("Ihr Ergebnis lautet {0}\n", potenz(eingabeA, eingabeB));
                    break;
                default:
                    Console.WriteLine("Ihre Eingabe war ungültig");
                    break;
            }
             
            
        }
    }
}
