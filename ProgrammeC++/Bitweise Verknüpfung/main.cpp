#include <iostream>

using namespace std;

int main()
{
    int wert, maske, eingabe1, eingabe2;
    cout << "Bitte geben Sie ihren Wert ein" << endl;
    cin >> eingabe1;
    cout << "Bitte geben Sie nun die groesse der Maske ein" <<endl;
    cin >> eingabe2;
    cout << endl;
    wert = eingabe1;
    maske = eingabe2;
    cout << "Bitweise UND" << endl;
    cout << (wert & maske) << endl;
    cout << "Bitweise ODER" << endl;
    cout << (wert | maske) << endl;
    cout << "XOR - Verknuepfung" << endl;
    cout << (wert ^ maske) << endl;
    return 0;
}
