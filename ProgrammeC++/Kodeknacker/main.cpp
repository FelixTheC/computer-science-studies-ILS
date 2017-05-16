/*#########################################
######### Kodeknacker #####################
#########################################*/
#include<iostream>
#include <cstdio>

using namespace std;

//die Prototypen für die Funktionen

void dreherKnacken(string);
void caesarKnacken (string);
void gartenzaunKnacken (string);

//die Funktionzum Umdrehen
void dreherKnacken(string kette)
{
    //die Länge der ursprünglichen Zeichenkette ermitteln
    int laenge;
    laenge = kette.length();
    //wieder 1 abziehen da length die "echte" Länge liefert
    laenge = laenge - 1;
    cout<< "Das Umdrehen ergibt: "<< endl;

    //die Zeichen von hinten nach vorne ausgeben

    for (int zaehler = laenge; zaehler = 0; zaehler--)
        cout << kette[zaehler];

    cout << endl << endl;
}
//die Funktion zum Knacken der Cäsar-Verschlüsselung
void caesarKnacken(string kette)
{
    int laenge, verschiebung;
    laenge = kette.length();
    cout<< "Durchprobieren der Caesar-Verschlüsselungen"<<endl;

    //alle Verschiebewerte von 1 bis 255 durchgehen
    for (verschiebung =1; verschiebung <= 255; verschiebung++)
    {
        cout<< "Mit der Verschiebezahl "<< verschiebung<< "ist das Ergebnis: ";
        //jedes Zeichen um den angegeben Wert verschieben, diesmal aber nach links
        for (int zaehler = 0; zaehler < laenge; zaehler ++)
            cout << static_cast<char>(kette[zaehler] - verschiebung);
        cout << endl;

        // alle 10 Ausgaben auf eine Eingabe warten
        if (verschiebung % 10 == 0)
            getchar();
    }
    cout<< endl <<endl;
}
void gartenzaunKnacken(string kette)
{
    string dekodiert, teil1, teil2;
    int laenge;
    int mitte;

    laenge = kette.length();
    //die mitte finden
    mitte = laenge / 2;
    // wenn es eine ungerade Anzahl ist, noch 1 Addieren
    if (laenge % 2 != 0)
        mitte++;
    //die Zeichenkette zerlegen
    teil1 = kette.substr(0, mitte);
    teil2 = kette.substr(mitte, laenge);
    for (int zaehler =0; zaehler < laenge; zaehler++)
    {
        //Zeichen mit einem geraden Index kommen in teil1
        if (zaehler % 2 ==0)
            dekodiert.push_back(teil1[zaehler/2]);
        // die ungerade kommen in teil2
        else
            dekodiert.push_back(teil2[zaehler/2]);
    }
    cout << "Der Versuch mit der Gartenzaunverschluesselung ergibt: "<<endl;
    cout<< dekodiert << endl;
}
int main()
{
    string eingabe;
    //die ursprüngliche Zeichenkette einlesen
    cout << "Bitte geben sie eine Zeichenkette (ohne leerzeichen) ein." << endl;
    cin>> eingabe;
    cout << "Die ursprüngliche Zeichenkette lautet." << endl;
    cout << eingabe << endl;

    //die Funktionen einsetzten
    dreherKnacken(eingabe);
    caesarKnacken(eingabe);
    gartenzaunKnacken(eingabe);

    return 0;

}











