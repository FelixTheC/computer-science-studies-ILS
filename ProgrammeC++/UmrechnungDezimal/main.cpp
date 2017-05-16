/*################################################################
#### Umrechnung von Dezimalzahlen in Dualzahlen Version 1.0 ######
################################################################*/
#include <iostream>

using namespace std;

int main()
{
    int zahl, zwischenergebnis;
    //den Wert einlesen
    cout<< "Geben Sie den Wert ein, den Sie umgerechnet haben möchten \n";
    cin>> zahl;
    // die Schleife
    do {
        // durch 2 teilen und das Ergebnis speichern
        zwischenergebnis = zahl / 2;
        // den Rest der Zahl ausgeben
        cout << zahl % 2;
        // das Ergebnis als neuen Wert benutzen
        zahl = zwischenergebnis;
    }
    while (zahl !=0);

    cout<< "\tBitte die Lösung von rechts nach links lesen!! \n\n";
    return 0;
}
