using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zeichenketten_verändern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vereinbarung
            string zKette1 = "Rätsel";

            //Leerzeichen vorne und hinten entfernen
            Console.WriteLine(zKette1);
            zKette1 = zKette1.Trim();
            Console.WriteLine(zKette1);
    
            //gezielt einzelne Zeichen vorne und hinten entfernen
            zKette1 = zKette1.Trim('R', 'l');
            Console.WriteLine(zKette1);
            //und wieder einfügen
            zKette1 = zKette1.Insert(0, "R");
            Console.WriteLine(zKette1);

            zKette1 = zKette1.Insert(zKette1.Length, "l");
            Console.WriteLine(zKette1);

            //ersetzen geht auch
            zKette1 = zKette1.Replace("ä", "ae");
            Console.WriteLine(zKette1);

            //alles in Großbuchstaben
            zKette1 = zKette1.ToUpper();
            Console.WriteLine(zKette1);
            //alles in Kleinbuchstaben
            zKette1 = zKette1.ToLower();
            Console.WriteLine(zKette1);
        }
    }
}
