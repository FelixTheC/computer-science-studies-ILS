#include <iostream>

using namespace std;

int main()
{
    int zahl;
    cout << "Geben Sie eine Zahl ein:";
    cin >> zahl;
    //die Abfrage
    if (zahl > 10)
        cout << "Die Zahl ist groeßer als 10";
    else cout << "Die Zahl ist kleiner als 10" << endl;

    return 0;
}
