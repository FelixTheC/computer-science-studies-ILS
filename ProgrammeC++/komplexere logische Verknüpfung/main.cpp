#include <iostream>

using namespace std;

int main()
{
    int zahl;
    cout << "Bitte Zahl eingeben" << endl;
    cin >> zahl;

    if (zahl >=10 && zahl <=20 && zahl !=15 )
        cout << "Die Bedingung trifft zu!" << endl;
    else
        cout << "Die Bedingung trifft nicht zu!" << endl;
    return 0;
}
