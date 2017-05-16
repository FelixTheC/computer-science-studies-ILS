#include <iostream>
#include <algorithm>
#include <vector>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    //die maximale Anzahl der Werte
    const int MAX = 10000;
    //ein Vector für die Werte
    vector<int>werte;
    //der Zufallsgenerator
    srand(time(NULL));

    cout << "Sortieren über die Klasse Vector" << endl;
    // die Werte anhängen, nur zufällige Zahlen bis 200 benutzen
    for (int index = 0; index < MAX; index++)
        werte.push_back(rand() % 200);

    // zur Kontrolle unsortiert ausgeben
    cout << "Die unsortierten Werte sind: " << endl;
    for (int index = 0; index < MAX; index++)
        cout << werte[index] << ' ';
    // die Werte sortieren
    //dazu wird die Methode sort mit dem Anfang und dem Ende der Liste aufgerufen
    sort(werte.begin(), werte.end());

    // und ausgeben
    cout << endl;
    cout << "Die sortierten Werte sind: " << endl;
    for (int index = 0; index < MAX; index++)
        cout << werte[index] << ' ';
    return 0;
}
