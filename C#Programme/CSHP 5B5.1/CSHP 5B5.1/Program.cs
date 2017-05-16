/*###########################################
 Einsendeaufgabe 5.1
 ##########################################*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP_5B5._1
{
    //die Klasse erstellen
    class Fernseher
    {
        //die Felder
        int lautstaerke;
        int programm;
        bool anaus;

        //die Methoden
        public void power(int strom)
        {
            if (strom == 1)
            {
                anaus = true;
                programm = 1;
                lautstaerke = 1;
            }
            else
            {
                anaus = false;
                programm = 0;
                lautstaerke = 0;
            }
         
        }

        public void lauter(int volumen)
        {   //nur wenn der Fernseher auch an ist
            if (anaus == true)
            {   //maximal lautstärke
                if (volumen < 30)
                {
                    lautstaerke = lautstaerke + (volumen-1);
                }
                else
                {
                    lautstaerke = 30;
                }
            }
            else
                Console.WriteLine();
        }
        public void sender(int wechsel)
        {   //nur wenn der Fernseher an ist
            if (anaus == true)
            {
                //maximale Anzahl an Sendern
                if (wechsel > 30)
                {
                    programm = 1;
                }
                else
                {   //Sender sieben ist ja nicht sender 3 plus sender 4
                    programm = programm + wechsel - programm;
                }

            }
            else
                Console.WriteLine();
        }
      
        
        public void ausgeben()
        {
            if (anaus == false)
            {
                Console.WriteLine("Der Fernseher ist aus folgender Sender {0} ist gewählt und die Lautstärke ist {1}", programm,lautstaerke);
            }
            else
                Console.WriteLine("Der Fernseher ist an \nund folgernder Sender wurde gewählt {0} und die Lautstärke ist {1}", programm, lautstaerke);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //eine Instanz erzeugen für einen Fernseher da ja nicht alle Fernseher das selbe machen
            Fernseher tv = new Fernseher();
            //der Fernseher befindet sich im Start zustand
            tv.power(0);
            tv.ausgeben();
            Console.WriteLine();
            
            //den Fernseher anschalten
            tv.power(1);
            tv.ausgeben();
            Console.WriteLine();
            
            //Den Sender Wechseln
            tv.sender(7);
            tv.ausgeben();
            Console.WriteLine();
            
            //Die Lautstärke voll aufdrehen und den Sender noch einmal wechseln
            tv.sender(2);
            tv.lauter(40);
            tv.ausgeben();
            Console.WriteLine();
           
            //den Fernseher wieder ausschalten
            tv.power(0);
            tv.ausgeben();
            Console.WriteLine();
            //wieder einschalten und mehr Sender eingeben als vorhanden
            tv.power(1);
            tv.sender(35);
            tv.lauter(20);
            tv.ausgeben();
            Console.WriteLine();
        }
    }
}
