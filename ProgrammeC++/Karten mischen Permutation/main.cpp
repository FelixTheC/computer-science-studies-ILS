#include <iostream>
// für random_shuffel
#include <algorithm>

using namespace std;

void mischen (int[], int);
void mischen (int karten [], int wiederholung)
{
    for (int nochMal = 0; nochMal < wiederholung; nochMal ++)
    {
        //eine Permutation mit random_shuffel durchführen
        random_shuffle(karten, karten + 32);
        cout << "Durchgang" << nochMal + 1 << endl << endl;
        // ausgeben
        for (int index = 0; index < 32; index ++)
            cout << "An Position" << index + 1 << " steht die Karte " << karten[index] << endl;
    }
}

int main()
{
    int spielkarten[32];
    // das Feld mit den Werten 1 bis 32 belegen
    for (int index = 0; index < 32; index++)
    spielkarten[index] = index +1;

    // erste Ausgabe
    for (int index = 0; index < 32; index ++)
        cout << "An Position " << index + 1 << " steht die Karte " << spielkarten[index] << endl;

    // und fünf mal mischen
    mischen (spielkarten, 5);

    return 0;
}
