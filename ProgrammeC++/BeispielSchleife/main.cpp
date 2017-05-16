/*################################################
########### Ein einfaches Beispiel ###############
################################################*/

#include <iostream>

using namespace std;

int main()
{
    //Vereinbarung und Initialisierung der Variablen
    int zahl1 = 0, zahl2 = 0, ergebnis;

    // das einlesen der Schleife
    while (zahl1 ==0) {
        cout<< "Bitte geben Sie die erste Zahl ein \n";
        cin >> zahl1;
    }
    while (zahl2 ==0) {
        cout<< "Bitte geben Sie die zweite Zahl ein \n";
        cin>> zahl2;
    }
    // die Addition
    ergebnis = zahl1 + zahl2;
    if (ergebnis >10)
        cout<< "Das Ergebnis ist groesser als Zehn \n" << ergebnis << endl;

    else
        cout << "Das Ergebnis ist kleiner als Zehn \n" << ergebnis << endl;
    return 0;
}
