using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eine_Struktur_im_Einsatz
{
    class Program
    {
        //die Vereinbarung der Struktur
        //sie erfolgt außerhalb der Methoden
        struct Kiste
        {
            public int Hoehe;
            public int Breite;
            public int Laenge;
        }
        //die Methode zum Einlesen, sie liefert die "komplette" Kiste zurück
        static Kiste einlesen(int kistenNummer)
        {
            //eine lokale Strukturvariable
            Kiste aKiste;
            Console.WriteLine("Geben Sie die Höhe der {0} Kiste ein: ", kistenNummer);
            aKiste.Hoehe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die Breite der {0} Kiste ein: ", kistenNummer);
            aKiste.Breite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie die Länge der {0} Kiste ein: ", kistenNummer);
            aKiste.Laenge = Convert.ToInt32(Console.ReadLine());

            //eine leere Zeile ausgeben
            Console.WriteLine();
            return aKiste;
        }
        //die Methode zum Berechnen des Volumens
        static int Volumen(Kiste aKiste)
        {
            int volWert;

            volWert = aKiste.Breite * aKiste.Hoehe * aKiste.Laenge;
            return volWert;
        }
        static void Main(string[] args)
        {
            //ein lokales Array kleineKiste für die Struktur Kiste
            Kiste[] kleineKiste = new Kiste[3];
            //das Einlesen der Daten über die Methode einlesen
            for (int index = 0; index < 3; index++)
                kleineKiste[index] = einlesen(index + 1);
            //das Berechnen über die Methode Volumen()
            for (int index = 0; index < 3; index++)
                Console.WriteLine("Das Volumen von Kiste {0} ist: {1}", index + 1, Volumen(kleineKiste[index]));
        }
    }
}
