/* #################################################
Ein simulierter Volladdierer
################################################# */

#include <iostream>

using namespace std;

//die Prototypen für die Funktionen
bool und(bool, bool);
bool oder(bool, bool);
bool nicht(bool);
void halbaddierer(bool, bool);
void volladdierer(bool, bool, bool);

//die eigentlichen Funktionen
bool und(bool e1, bool e2)
{
    bool a;
    a = e1 && e2;
    return a;
}

bool oder(bool e1, bool e2)
{
    bool a;
    a = e1 || e2;
    return a;
}

bool nicht(bool e)
{
    bool a;
    a = !e;
    return a;
}


void volladdierer(bool e1, bool e2, bool uebertrag)
{
    bool u1, ergebnis1, u2, ergebnis2, u3;
    cout << "Die Eingangswerte sind " << e1 << ", " << e2 << " und " << uebertrag << endl;
    //der erste Halbaddierer
    //Der Übertrag
    u1 = und(e1, e2);
    ergebnis1 = und(nicht(u1), oder(e1,e2));
    //der zweite Halbaddierer
    u2 = und(ergebnis1, uebertrag);
    ergebnis2 = und(nicht(u2), oder(ergebnis1, uebertrag));

    //die Überträge verknüpfen
    u3 = oder(u1, u2);

    cout << "Der Uebertrag ist " << u3 << endl;
    cout << "Das Ergebnis ist " << ergebnis2 << endl <<endl;
}

int main()
{
    cout << "Ein Volladdierer" << endl;
    volladdierer(0,0,0);
    volladdierer(0,0,1);
    volladdierer(1,0,0);
    volladdierer(1,0,1);
    volladdierer(1,1,0);
    volladdierer(1,1,1);

    return 0;
}
