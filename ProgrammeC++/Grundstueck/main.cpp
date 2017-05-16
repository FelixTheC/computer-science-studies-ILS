#include <iostream>

using namespace std;

int main()

{
    float kosten;
    float gesamt;
    float wert1;
    float wert2;
    float summe;
    cout << "Was sind die Kosten pro Quadratmeter?? \n \'statt komma bitte punkt verwenden, falls sie keine ganze Zahl verwenden '\ \n";
    cin >> kosten;
    cout << "\nWie breit ist das Grundstueck?? \'bitte nur ganze Zahlen'\ \n";
    cin >> wert1;
    cout << "\nUnd wie lang ist das Grundstueck?? \'bitte nur ganze Zahlen'\ \n";
    cin >> wert2 ;
    summe = wert1 * wert2;
    gesamt = kosten * summe;
    cout << "\n";
    cout << gesamt;
    cout << " Das sind die Gesamtkosten die fuer das Grundstueck zu bezahlen sind \n\n";


    return 0;
}
