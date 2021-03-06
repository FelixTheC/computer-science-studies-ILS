#include <iostream>
#include <ctime>
#include <cstdlib>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
    const int MAX = 100;
    vector <int> werte;
    int kriterium ;
    bool gefunden = false;
    srand (time(NULL));
    cout << "Binaere Suche und Vector sortierung" << endl;
    for (int index = 0; index < MAX; index++)
        werte.push_back(rand() % 200);
    cout << "Unsortiert"<< endl;
    for (int index = 0; index < MAX; index++)
    cout << werte[index] << ' ';
    sort(werte.begin() , werte.end());
    cout << endl;
    cout << "Die sortierte Liste"<<endl;
    for (int index = 0; index < MAX; index++)
        cout << werte[index] << ' ';
    cout << endl;
    //Abfrage Suchkriterium
    cout << "Wonach soll gesucht werden?" << endl;
    cin >> kriterium;
    //Die eigentliche Suche
    for (int suchen = 0; suchen < MAX; suchen++)
    if  (werte[suchen] == kriterium){
        cout << "Der gesuchte Wert " << kriterium << " wurde gefunden" << suchen +1 <<endl;
        gefunden = true; }
   if (gefunden != true)
        cout << "Der gesuchte Wert " << kriterium << " wurde nicht gefunden" << endl;

    return 0;
}
