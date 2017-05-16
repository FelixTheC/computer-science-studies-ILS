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

    // der Zufallsgenerator
    srand(time(NULL));
    cout << "Bubbelsort" << endl;
    // die Werte setzen bis 200
    for (int index = 0; index < MAX; index++){
        werte[index] = rand() % 200;
    }
    // zur Kontrolle unsortiert ausgeben
    cout << "Die unsortierten Werte sind: " << endl;
    for (int index = 0; index < MAX; index++)
        cout << werte[index] << ' ';

    // Sortieren
    //alle Werte durchgehen und dann von vorne nach hinten vergleichen
    for (int i = 0; i < MAX; i ++)
        for (int k = 0; k < MAX -i -1; k++)
        // wenn das aktuelle Element größer ist als das Folgeelement, wird getauscht
    if (werte[k] > werte[k+1]){
        //den Wert sichern damit er nicht überschrieben wird
        tauschTemp = werte[k];
        werte[k] = werte[k + 1];
        werte[k + 1] = tauschTemp;
    }
    //die sortierte Ausgabe
    cout << endl;
    cout << "Die sortierten Werte sind: " << endl;
    for (int index =0; index < MAX; index++)
        cout << werte[index] << ' ';

    return 0;
}
