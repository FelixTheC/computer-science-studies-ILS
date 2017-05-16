#include <iostream>

using namespace std;

int berechung(int num1, int num2)
{
    int summe=0;
    int zaehler = 0;
    do{
        summe+=num1;
        ++zaehler;
    }
    while(zaehler != num2);

    return summe;
}

int main()
{
    int zahl1,zahl2;
    cout << "Bitte geben Sie die erste Zahl ein" << endl;
    cin >> zahl1;
    cout << "Bitte geben Sie jetzt ihre Zeit ein" <<endl;
    cin >> zahl2;
    cout << "Das ergebnis lautet: "<< berechung(zahl1,zahl2)<<endl;

    return 0;
}
