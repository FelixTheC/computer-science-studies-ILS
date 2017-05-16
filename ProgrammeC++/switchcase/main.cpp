#include <iostream>

using namespace std;

int main()
{
    int eingabe;
    // das Menü erzeugen
    cout << "Treffen Sie ihre Wahl \n";
    cout << "1 Berechnung starten \n";
    cout << "2 Neue Werte eingeben \n";
    cout << "3 Rechenmodus aendern \n";
    cout << "0 Programm beenden \n";
    cout << "Ihre Auswahl? \n";
    cin >> eingabe;

    // die Auswertung von eingabe

    switch (eingabe)
    {
        case 1:
            cout << "Sie haben die Funktion Berechnung starten gewaehlt \n";
            break;
        case 2:
            cout << "Sie haben \'Neue Werte'\ eingeben gewaehlt \n ";
            break;
        case 3:
            cout << "Sie haben \'Rechenmodus aendern'\ gewaehlt \n";
            break;
        case 0:
            cout << "Sie moechten das Programm beenden? \n";
            break;

            default:
            cout << "Ihre Auswahl war nicht korrekt!!!! \n";
    }
    return 0;
}
