#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
   //ein Feld zum Speichern der gewürfelten Zahlen
   //die Werte 0, werden direkt zugewiesen
   int zahlen[6] ={0,0,0,0,0,0,};

   int augen, anzahl;

   //den Zufallsgenerator initilasieren
   srand(time(NULL));

   //und nun würfeln
   for (anzahl=0; anzahl<20;anzahl++){
    augen = (rand()%6) +1;
    cout << augen<< '\t';
    zahlen[augen-1]++;
   }
   //die absoluten und relativen Häufigkeiten ausgeben
   cout<< "Es wurde"<< anzahl<< "Mal gewuerfelt"<<endl<<endl;
   for (int index =0; index <6; index++){
    cout << index +1;
    cout << "\tabsolut: "<< zahlen[index];
    cout << "\trelativ: "<< zahlen[index] / static_cast<float>(anzahl)<<endl;
   }
}
