#include <iostream>

using namespace std;

int main()
{   int bit[16];
    int positionieren =0;
    int n=1;
    int wert, ergebnis,ziel;
    for (int index =0; index <16; index ++)
        bit[index] = 0;

        cout << "Wert eingeben \n";
        cin>> wert;
    do {
         bit[positionieren] = wert % 10; //den letzten wert ablegen
         positionieren ++;               // zur nächsten position gehen
         wert = wert/10;                 // letzte stelle löschen
        } while (wert !=0);             // das ganze solange machen bis keine stelle mehr übrig ist

    for (int ergebnis =0; ergebnis < 16;ergebnis++);
        {ziel= ziel + bit[ergebnis] * n;
        n=n*2;}



    cout << ziel << endl;
    return 0;
}





    int wert, ergebnis, n, ziel;

    do {
        cout << "Gib zahl ein \n";
        cin >> wert;

    } while (wert > 11111111111111111);

    do {
            wert[bit];
            ergebnis[bit] = wert * (2*n);
        n=n*2;
        ergebnis[bit]= ergebnis %10;
            ziel = ergebnis + bit;
    } while (bit !=0);

        cout << ziel;

    return 0;
}
