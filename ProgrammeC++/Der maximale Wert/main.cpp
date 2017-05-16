#include <iostream>
#include <limits>

using namespace std;

int main()
{
    // den maximalen Wert ermitteln
    int maxInt = numeric_limits<int>::max();

    cout << "Der maximale Wert für int ist:" << maxInt << endl;
    cout << "Die menge ist endlich" << endl;

    // der Überlauf

    cout << "Denn nach dem maximalen Wert kommt: " << maxInt +1 << endl;
    return 0;
}
