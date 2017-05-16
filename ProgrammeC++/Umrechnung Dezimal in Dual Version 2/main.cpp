#include <iostream>

using namespace std;

int main ()
{
    int wert, zahl, position= 0;
    // das Feld zum Speichern der Reste
    int reste[16];
    //Das Feld wird mit 0 besetzt
    for (int index=0; index < 16;  index ++)
        reste[index] = 0;
    // den Wert einlesen
    do {
        cout << "Geben Sie bitte einen Wert ein der umgerechnet werden soll \n";
        cin >> zahl;
        cout << "Mit welcher Basiszahl soll die umrechnung stattfinden?? Zwischen 2 und 9 \n";
        cin >> wert;
    }
     while (zahl > 65535);

        // die Schleife

     do {
            // den Rest der Division qblegen
        reste[position] = zahl %wert;
     // zur nächsten Position gehen
     position++;
     //durch x teilen und wieder zuweisen
     zahl = zahl /wert;
     }
     while (zahl !=0);
     // die "Reste" von hinten nach vorne ausgeben
     for (int index = 15; index >=0; index--) {
        cout << reste[index];
        // alle 4 Stellen fügen wir eine Leerstelle für die Obtik ein
        if (index % 4 == 0)
            cout << "  ";
     }
    return 0;
}
