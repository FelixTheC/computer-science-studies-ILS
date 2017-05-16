#include <iostream>

using namespace std;

int main()
{   int eingabe, eingabe2;
    long double fakultaet1 = 1, fakultaet2 = 1, fakultaet3 = 1;

    cout << "Geben Sie bitte die Anzahl der vorhandenen Element ein" << endl;
    cin >> eingabe;
   for (int n = eingabe; n > 0; n --)
        fakultaet1 = fakultaet1 * n;
    cout << "Geben Sie bitte die Anzahl der Plaetze ein" << endl;
    cin >> eingabe2;
    if (eingabe2 > eingabe)
           {
               cout << "Bitte Tauschen Sie die Werte um, da das Ergbeniss fehlerhaft wird" << endl;
               return 0;}


  for (int d = eingabe-eingabe2; d > 0; d--)
    fakultaet2 = fakultaet2 * d;
    fakultaet3 = fakultaet1 / fakultaet2;

        cout << "Die Anzahl der Moeglichkeiten lautet " << fakultaet3 << endl;

    return 0;
}
