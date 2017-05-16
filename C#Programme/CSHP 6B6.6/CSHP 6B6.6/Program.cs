using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP_6B6._6
{
    class Insekt
	{
		protected int laenge;
		protected int gewicht;

		//der Konstruktor

		public Insekt(int laenge, int gewicht)
		{
			this.laenge = laenge;
			this.gewicht = gewicht;
		}
	
		//die Methode zum essen
		public virtual void Essen( )
		{
			laenge = laenge + 1;
			gewicht = gewicht + 1;
		}

		//die Methode zur Ausgabe
		public virtual void Ausgabe( )
{
     Console.WriteLine("Das Insekt ist {0} cm lang und wiegt {1} Gramm ", laenge, gewicht);
}

}
    //die Klasse Libelle erbt von der Klasse Insekt
    class Libelle : Insekt
    {   //ein eigenes Feld
        int fluegelLaenge;
        //der Konstruktor für die Klasse Libelle
        public Libelle(int laenge, int gewicht, int fluegelLaenge) : base(laenge,gewicht)
        {
            this.fluegelLaenge = fluegelLaenge;
        }
        //die Methode Essen der Klasse Insekt wird überschrieben
        public override void Essen()
        {
            base.Essen();
            fluegelLaenge = fluegelLaenge + 1;
        }
        //die Methode Ausgabe der Klasse Insekt wird überschrieben
        public override void Ausgabe()
        {
            Console.WriteLine("Die Libelle ist {0} cm lang und wiegt {1} Gramm \nund hat eine Flügellänge von {2} cm\n ", laenge, gewicht, fluegelLaenge);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Instanzen erstellen
            Insekt kaefer = new Insekt(20, 10);
            Libelle kleineLibelle = new Libelle(50, 30, 100);

            kaefer.Ausgabe();
            kleineLibelle.Ausgabe();

            kaefer.Essen();
            kleineLibelle.Essen();

            kaefer.Ausgabe();
            kleineLibelle.Ausgabe();
        }
    }
}
