/*####################################################################
    Einsendeaufgabe 4
 ###################################################################*/
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
        static Kiste Eingabe(int box)
        {
            //Struktur Variable
            Kiste eineKiste;

            Console.WriteLine("Die Breite von Kiste {0}", box);
            eineKiste.breite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Die Höhe von Kiste {0}", box);
            eineKiste.hoehe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Die Länge von Kiste {0}", box);
            eineKiste.laenge = Convert.ToInt32(Console.ReadLine());
            
            return eineKiste;
        }

        static int Volumen(Kiste eineKiste)
        {
            //die Rechnung für das Volumen
            int summe; 
            summe = eineKiste.breite * eineKiste.hoehe * eineKiste.laenge;
            return summe;
        }
        //das mit dem Mehrdimensionalen Array hat nicht so Funktioniert wie ich mir das Gedacht habe deshalb habe ich
        //diese Variante gewählt, auch wenn es nicht schön ist
        static int Spalte1(Kiste eineKiste)
        {
            int spalte1;
            spalte1 = eineKiste.breite + 0;
            return spalte1;
         }
        static int Spalte2(Kiste einKiste)
        {
            int spalte2;
            spalte2 = einKiste.hoehe + 0;
            return spalte2;
        }
        static int Spalte3(Kiste eineKiste)
        {
            int spalte3;
            spalte3 = eineKiste.laenge + 0;
            return spalte3;
        }
        //es macht am Ende das was es soll

        static Kiste Aendern(int neuebox)
        {
            //zum Ändern der Eingabe habe ich Kiste Eingabe übernommen
            Kiste eineKiste;
            Console.WriteLine("Die Breite von Kiste {0}", neuebox);
            eineKiste.breite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Die Höhe von Kiste {0}", neuebox);
            eineKiste.hoehe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Die Länge von Kiste {0}", neuebox);
            eineKiste.laenge = Convert.ToInt32(Console.ReadLine());

            return eineKiste;
              
        }

        static Kiste Delete(int leereKiste)
        {
           //zum Löschen der Eingabe setzte ich alle Kiste Eingaben wieder auf Null 
            //auch wenn die Kiste trotzdem existiert enthält sie keine Werte mehr
            Kiste eineKiste;
            eineKiste.breite = 0;
            eineKiste.hoehe = 0;
            eineKiste.laenge = 0;
            Console.WriteLine("Ihre Kiste {0} ist jetzt gelöscht", leereKiste);

            return eineKiste;
        }
   

        static void Main(string[] args)
        {
            //zur Eingabe
            int auswahl;
            //um zusehen wieviele Eingaben bzw Kisten erstellt wurden
            int zaehler = 0;
            int wahl = 0;
            //Array erstellen
            Kiste[] dieKiste = new Kiste[50];
            //beginn der Schleife
        do{
            Console.WriteLine("Was möchten Sie machen??");
            Console.WriteLine("Drücken Sie \nE für die Eingabe einer neuen Kiste\nL für das Löschen einer Kiste\nA zum Ändern einer Kiste\nD für die Daten einer einzelnen Kiste\nT für die Liste\nzum Beenden drücken Sie bitte die x");
            auswahl = Convert.ToChar(Console.ReadLine());
            switch (auswahl)
            {
                case 'E':
                case 'e':
                    //um immer nur eine Kiste zu erstelle und ihr eine Fortlaufenden Nummer zuzuweisen
                    wahl++;
                    int n = wahl;
                    if (wahl == n)
                    {
                        dieKiste[n] = Eingabe(n);
                        zaehler++;
                    }
                        //Damit nicht mehr Kisten erstellt werden können als Speicher im Array vorhanden ist
                    else if (zaehler >= 50)
                    {
                        Console.WriteLine("Das ist ihre letzte Kiste");
                        break;
                    }
                    
                        break;
                case 'L':
                case 'l':
                    //wenn noch nichts erstellt wurde
                        if (zaehler == 0)
                        { Console.WriteLine("Sie können noch keine Kiste löschen, da noch keine erstellt wurde"); }
                        //sobald eine Kiste erstellt wurde
                        else
                        {
                            Console.WriteLine("Welche Kiste möchten Sie löschen??");
                            wahl = Convert.ToInt32(Console.ReadLine());
                            //damit auch wirklich nur auf erstellte Kisten zugegriffen werden kann
                            if (wahl > zaehler)
                            { 
                                Console.WriteLine("\nDiese Kiste existiert nicht\n"); 
                            }
                            else
                            {
                                int d = wahl;
                                if (wahl == d)
                                {
                                    dieKiste[d] = Delete(d);
                                }
                            }
                        }
                    break;
                case 'A':
                case 'a':
                    //wenn noch nichts erstellt wurde
                    if (zaehler == 0)
                    { Console.WriteLine("Sie können noch keine Kiste Ändern, da noch keine erstellt wurde"); }
                    //sobald die erste Kiste erstellt wurde
                    else
                    {
                        Console.WriteLine("Welche Kiste möchten Sie Ändern??");
                        wahl = Convert.ToInt32(Console.ReadLine());
                        //damit auch wirklich nur auf erstellte Kisten zugegriffen werden kann
                        if (wahl > zaehler)
                        { 
                            Console.WriteLine("\nDiese Kiste existiert nicht\n");
                        }
                        else
                        {
                            int z = wahl;
                            if (wahl == z)
                            {
                                dieKiste[z] = Aendern(z);
                            }
                        }
                    }
                    
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Von welcher Kiste möchten Sie sich die Daten anzeigen lassen??");
                    //Um Speziell nur eine Kiste auszuwählen
                    wahl = Convert.ToInt32(Console.ReadLine());
                    //auch hier Überprüfe ich die Eingabe mit der Vorhandenen Anzahl von Kisten
                    if (wahl > zaehler)
                    {
                        Console.WriteLine("\nDa haben wir noch nichts\n");
                    }
                    else
                    {
                        Console.WriteLine("\nKiste {0} Breite:{1} Höhe:{2} Länge:{3} Volumen:{4}\n", wahl, Spalte1(dieKiste[wahl]), Spalte2(dieKiste[wahl]), Spalte3(dieKiste[wahl]), Volumen(dieKiste[wahl]));
                    }
                        break;
                case 'T':
                case 't':
                    //die Tabelle ist sogroß wie der Zaehler bei 0 gibt es auch keine Tabelle :)
                    for (int index = 1; index <= zaehler; index++)
                        Console.WriteLine("\nKiste {0} Breite:{1} Höhe:{2} Länge:{3} Volumen:{4}\n", index,Spalte1(dieKiste[index]),Spalte2(dieKiste[index]),Spalte3(dieKiste[index]),Volumen(dieKiste[index]));
                       
                      break;
                default:
                      if (auswahl == 'x')
                      { Console.WriteLine();
                      break;
                      }
                else
                    Console.WriteLine("\nIhre Eingabe ist Ungültig\n");
                    break;
            }
            //um aus der Schleife zu kommen
        }while(auswahl !='x');
        }
    }
}
