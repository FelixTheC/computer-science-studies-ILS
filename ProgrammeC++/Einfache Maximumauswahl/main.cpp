#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main()
{
   // die maximale Anzahl der Werte
   const int MAX = 10;
   // ein Feld für die Werte
   int werte[MAX];
   // eine Hilfsvariable für den Tausch
   int tauschTemp;
   // für das vorläufige Maximum
   int maximum;
   // den Zufallsgenerator initialisieren
   srand(time(NULL));

   cout << "Einfache Maximumauswahl" << endl;
   // die Werte setzen, benutzt werden zufällige Zahlen bis 200
   for (int index = 0; index < MAX; index++){
    werte[index] = rand() % 200;
   }
   // zur Kontrolle unsortiert ausgeben
   cout << "Die unsortierten Werte sind: " << endl;
   for (int index = 0; index < MAX; index++)
    cout << werte[index] << ' ';
   //solange der unsortierte Bereich mehr als 1 Element enthält
   for (int k = MAX -1; k > 0; k--){
        maximum = k;
   for (int i = 0; i < k; i ++)
    // das letzte Element wird zum vorläufigen Maximum
    if (werte[maximum] < werte [i])
        maximum = i;
    // die Werte tauschen
    if (maximum != k) {
        tauschTemp = werte[k];
        werte[k] = werte[maximum];
        werte[maximum] = tauschTemp;
    }
   }
   // die sortierte Ausgabe
   cout << endl;
   cout << "Die sortierte Werte sind: " << endl;
   for (int index = 0; index < MAX; index++)
    cout << werte[index] << ' ';
    return 0;
}
