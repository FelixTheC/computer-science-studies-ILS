#include <iostream>

using namespace std;

int main()
{
    //die beiden Mengen
    int mengeA[] = {1, 2, 3, 4, 5};
    int mengeB[] = {3, 4, 5, 6, 7};

    // für die Verknüpfung
    int mengeC[5];

    int count = 0;
    // das Ziel mit 0 belegen
    for (int i = 0; i < 5; i++)
        mengeC[i] = 0;

    // die Schnittmenge bilden
    for (int a = 0; a < 5; a++)
    for (int b = 0; b < 5; b++) {
        // wenn das Element in A mit dem Element in B übereinstimmt in C kopieren
        if (mengeA[a] == mengeB[b]) {
            mengeC[count] = mengeA[a];
            count ++;
        }
    }
    // und ausgeben
    cout << "Die Schnittmenge ist: " << endl;
    for (int i = 0; i < 5; i++)
        if (mengeC[i] != 0)
        cout << mengeC[i] << ' ';
    return 0;
}
