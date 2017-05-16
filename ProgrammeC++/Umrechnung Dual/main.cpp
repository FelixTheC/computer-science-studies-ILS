#include <iostream>

using namespace std;

int main()
{   int zahl;
    int n = 1, position = 0, ergebnis = 0;
    int ziffer[16];                                 //das Feld zum Speichern der Stellen in dem Fall werden 16 Stellen gespeichert

    for (int index = 0; index < 16; index++)
        ziffer[index] = 0;                          // das Feld wird hier mit 0 besetzt
    do {
    cout << "Geben Sie die Dualzahl ein (max 16 bit):\n";
    cin >> zahl;
    } while (zahl > 1111111111111111);

    do  {
            ziffer[position] = zahl % 10;     //die letzte Ziffer wird abgelegt
            position++;                         //weiter geht es zur nächsten Position
            zahl = zahl / 10;                   // hier wird die letzte Stelle gelöscht
    } while (zahl!=0);
    for (int schleife = 0; schleife < 16; schleife++)
    {ergebnis = ergebnis + ziffer[schleife] * n;
    n = n * 2;}

    cout <<"Der Dezimalwert lautet "<< ergebnis << endl;


    return 0
}
/* Umgangssprächlich:
Erst gebe ich die maximale Anzahl der Stellen vor
von rechts beginnend wird jede stelle einzelnt ausgewählt und dann gelöscht
als ich meine Aufzeichnungen durch geschaut hatte wollte ich zu erst von links anfangen
aber von rechts macht eindeutig mehr sinn.
wichtig ist aber das ich n = n*2 zuweise damit ich die potenzen habe.
