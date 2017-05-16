/*###################################################
 Einsendeaufgabe 5.3
 ##################################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Einfache_Liste_2
{
    class Program
    {
        public class Listenelement
        {
            private string daten;
            Listenelement naechster;
            Listenelement letzter;

            public void SetDaten(string datenNeu)
            {
                daten = datenNeu;
                naechster = null;
            }

            public Listenelement Anhaengen(string datenNeu)
            {
                if (naechster == null)
                {
                    naechster = new Listenelement();
                    naechster.letzter = this;
                    naechster.SetDaten(datenNeu);
                }
                else
                {
                    return naechster.Anhaengen(datenNeu);
                }
                return this.naechster;
            }

            public void Ausgeben()
            {
                Console.WriteLine(daten);
                if (naechster != null)
                    naechster.Ausgeben();
            }

            public void AusgebenRueckwaerts()
            {
                Console.WriteLine(daten);
                if (letzter != null)
                    letzter.AusgebenRueckwaerts();
            }
        }

        static void Main(string[] args)
        {
            Listenelement listenAnfang = new Listenelement();
            Listenelement listenEnde = new Listenelement();
            char eingabe;

                listenAnfang.SetDaten("Element 1");
                //Da in der Aufgabe verlangt wurde das man wählen kann habe ich hier eine switch Anweisung eingefügt
                //(...so, dass die Liste auch rückwärts ausgegeben werden KANN
              
                    Console.WriteLine("Möchten Sie sich die Liste normal 'n' oder rückwärts 'r' ausgeben lassen?? \nZum beenden 'x' drücken");
                    eingabe = Convert.ToChar(Console.ReadLine());
                    switch (eingabe)
                    {
                        case 'n':
                            {
                                for (int element = 2; element <= 10; element++)
                                {
                                    listenEnde = listenAnfang.Anhaengen("Element " + element);
                                }

                                listenAnfang.Ausgeben();

                            }
                            break;

                        case 'r':
                            {
                                for (int element = 2; element <= 10; element++)
                                {
                                    listenEnde = listenAnfang.Anhaengen("Element " + element);
                                }

                                listenAnfang.Ausgeben();
                                listenEnde.AusgebenRueckwaerts();

                            }
                            break;

                        case 'x':
                            {
                                break;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Die Eingabe ist ungültig");
                            }
                            break;
                    }
        }
    }
}