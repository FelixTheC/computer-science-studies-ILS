#include <iostream>


using namespace std;

int main()
{
    int laenge, verschiebung = 1;
    string eingabe;
    cout << "Text ohne leerzeichen eingeben" << endl;
    cin >> eingabe;

    laenge = eingabe.length();

    for (int zaehler = 0; zaehler < laenge; zaehler ++)

    cout << static_cast<char>(eingabe[zaehler] + (verschiebung+zaehler));


    return 0;
}
