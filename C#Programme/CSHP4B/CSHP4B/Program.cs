using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP4B
{
    class Program
    {   //eine Kiste
        struct Kiste
        {
            public int breite;
            public int hoehe;
            public int laenge;
        }
        static Kiste Eingabe (int box)
        {
            //Struktur Variable
            Kiste eineKiste;
                Console.WriteLine("Die Breite von Kiste {0}",box);
                eineKiste.breite = Convert.ToInt32(Console.ReadLine());
               
            Console.WriteLine("Die Höhe von Kiste {0}",box);
                eineKiste.hoehe = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Die Länge von Kiste {0}",box);
                eineKiste.laenge = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();
                return eineKiste;
        }
        static int Volumen(Kiste eineKiste)
        {
            //die Rechnung für das Volumen
            int summe;
            summe = eineKiste.breite * eineKiste.laenge * eineKiste.hoehe;
            return summe;
        }
        static void Main(string[] args)
        {
            int auswahl;
            Kiste[] eineKiste = new Kiste[50];
          
            Console.WriteLine("Was möchten Sie machen??");
                Console.WriteLine("Drücken Sie \nE für die Eingabe einer neuen Kiste\nL für das Löschen einer Kiste\nA zum Ändern einer Kiste\nT für die Liste\nzum Beenden drücken Sie bitte die X");
                auswahl = Convert.ToChar(Console.ReadLine());
                switch(auswahl)
                {
                    case'E':
                    case 'e':
                        Console.WriteLine("Wieviele Kisten möchten Sie erstellen??");
                        int anzahl = Convert.ToInt32(Console.ReadLine());
                        for (int index = 0; index < anzahl; index++)
                         eineKiste[index] = Eingabe(index+1);
                       
                    break;
            case'L':
            case'l':
            break;
            case'A':
            case'a':
            break;
            case'T':
            case't':
            break;
            case'X':
            case'x':
            break;
            default:
            break;
                }
      
    }
}}
