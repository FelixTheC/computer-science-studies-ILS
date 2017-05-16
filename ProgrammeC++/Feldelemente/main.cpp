/*###################################################
########## Beispiel für ein Feld ####################
###################################################*/

#include <iostream>

using namespace std;

int main()
{
    int ergebnis = 0;
    // die Vereinbarung des Feldes
    int zahlenFeld[10];

    // das Einlesen in das Feld
    for (int schleife = 0; schleife < 10; schleife++ )
    {
        cout << "Bitte Zahl "<< schleife +1 << " eingeben ";
        cin >> zahlenFeld [schleife];
    }

    // die Berechnung
    for (int schleife =0; schleife < 10; schleife ++ )
        ergebnis = ergebnis + zahlenFeld [schleife];
    // die Ausgabe
    cout<< "Das Ergebnis der Addition ist: " << ergebnis << endl;
    return 0;
}
