#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;

int main()
{
    //die Maximale Anzahl Werte
    const int MAX = 200;
    //ein Feld für die Werte
    int werte[MAX];
    //wurde schon ein Wert gefunden
    bool gefunden = false;
    //für die Suche
    int suchen = 0;
    int kriterium = 0;

    //der Zufallsgenerator
    srand(time(NULL));

    cout << "Lineare Suche" << endl;
    //die Werte setzen, benutzt werden zufällige Zahlen bis 200

    for (int index = 0; index < MAX; index ++){
        werte[index] = rand() % 1000;
        }
        //zur Kontrolle ausgeben
        cout << "Die Werte sind: " << endl;
        for (int index = 0; index < MAX; index++)
            cout << werte[index] << ' ';
        cout << endl;

        //Abfrage des Suchkriterium
        cout << "Wonach soll gesucht werden?" << endl;
        cin >> kriterium;

        //suchen bis das Ende erreicht wurde oder die Zahl gefunden wird

      for (int suchen = 0; suchen < MAX; suchen ++)
            if (werte[suchen] == kriterium)
            {cout << "Der Wert " << kriterium << " befindet sich an der Position " << suchen + 1 << endl;
            gefunden = true;}



            if(gefunden != true)
                cout << "Der Wert " << kriterium << " wurde nicht gefunden" << endl;


    return 0;
}
