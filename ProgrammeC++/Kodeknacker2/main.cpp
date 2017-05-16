#include <iostream>

using namespace std;

int main()
{
    int eingabe;
    string dekodiert;
    do {//zahlen einlesen
        cout << "Bitte geben Sie die Zahl ein: (-1 zum Abbruch" << endl;
        cin >> eingabe;

        if (eingabe != -1)
            dekodiert.push_back(static_cast<char> (eingabe));

    }   while (eingabe != -1);
    cout << "Das Ergebnis ist" << dekodiert << endl;

    return 0;
}
