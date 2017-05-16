#include <iostream>

using namespace std;

int main()
{
    int zahl;
    cout << "Bitte geben Sie eine Zahl ein: " << endl;
    cin >> zahl;
    if (zahl <=20)
        cout << "Die eingegebene Zahl ist kleiner oder gleich 20" << endl;
    else
        if (zahl >=30)
        cout << "Die Zahl ist groesser oder gleich 30" << endl;
    else
        cout << "Die Zahl liegt zwischen 20 und 30" << endl;
    return 0;
}
