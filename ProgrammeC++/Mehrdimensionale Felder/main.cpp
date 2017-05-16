/*#######################################
#### Mehrdimensionale Felder ############
#######################################*/
#include <iostream>

using namespace std;

int main()
{
    // die Vereinbarung des Feldes
    int tabelle2 [3][5];

    // die Zuweisung in einer geschachtelten Schleife
    for (int dimension1 =0; dimension1 < 5; dimension1 ++)
        for (int dimension2 =0; dimension2 < 5; dimension2++)
        tabelle2 [dimension1][dimension2] = (dimension1 + 1) || (dimension2 +1);

    // die Ausgabe in einer geschachtelten Schleife
    for (int dimension1 =0; dimension1 < 5; dimension1++)
        for (int dimension2 =0; dimension2 < 5; dimension2 ++)
        cout << "Der Wert des Elements " << dimension1 << "  " << dimension2 << "ist" << tabelle2[dimension1] [dimension2]<< endl;
    return 0;
}
