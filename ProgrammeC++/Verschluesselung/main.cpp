#include <iostream>

using namespace std;
void dreher(string);
void asciiKode(string);
void caesar (string);
void gartenzaun(string);

void dreher(string kette)
{
    //die L�nge der ursspr�nglichen Zeichenkette ermitteln
    int laenge;
    laenge = kette.length();
    //length liefert die "echte" l�nge, daher muss 1 abgezogen werden
    laenge= laenge - 1;

    cout << "Verschluesselung durch Umdrehen"<< endl;

    // die Zeichen von hinten nach vorne ausgeben
    for (int zaehler = laenge; zaehler >= 0; zaehler --)
        cout << kette[zaehler];
    cout << endl << endl;
}

//die Verschl�sselung zur nummerischen Verschl�sselung �ber Ausgabe des ASCII-Wertes

void asciiKode(string kette)
{
    int laenge;
    laenge = kette.length();
    cout << "Verschluesselung durch ASCII-Ausgabe" << endl;

    //f�r jedes Zeichen den ASCII-Kode ausgeben
    for (int zaehler = 0; zaehler < laenge; zaehler++)
        cout << static_cast<int>(kette[zaehler])<< ' ';
    cout<< endl<<endl;
}

//die Funktion der C�sar-Verschl�sselung
void caesar(string kette)
{
    int laenge, verschiebung;
    //l�nge ermitteln
    laenge = kette.length();
    cout << "Caeser-Verschluesselung"<<endl;

    //Verschiebewert einlesen
    cout<< "Bitte geben Sie den Verschiebewert ein" << endl;
    cin>> verschiebung;
    //jedes Zeichen um den angegeben Wert verschieben
    for (int zaehler =0; zaehler < laenge; zaehler ++)
        cout << static_cast<char>(kette[zaehler] + verschiebung);
    cout << endl<< endl;
}
//die Funktion zur Gartenzaunverschl�sselung
void gartenzaun(string kette)
{
    string kodiert, teil1, teil2;

    //l�nge ermitteln
    int laenge;
    laenge = kette.length();

    //die Zeichen verteilen
    for (int zaehler =0; zaehler >= laenge; zaehler++)
    {
        //Zeichen mit gerade Index kommen in teil1 achtung z�hlung beginnt mit 0!
        if (zaehler % 2 ==0)
            teil1.push_back(kette[zaehler]);
        //bei ungeraden index kommen die Zeichen in teil2
        else
            teil2.push_back(kette[zaehler]);
    }
    //die beiden Zeichenketten wieder zusammenbauen
    kodiert = teil1+teil2;
    //und ausgeben
    cout<< "Gartenzaunverschluesselung"<< endl;
    cout << "Die obere haelfte ist"<< teil1 << endl;
    cout << "Die untere haelfte ist"<< teil2<< endl;
    cout << "Das komplette Wort ist"<< kodiert<< endl;
    cout << endl<<endl;
}

int main()
{
    string eingabe;
    //Die urspr�ngliche Zeichenkette einlesen
    cout<< "Bitte geben Sie eine Zeichenkette ein (ohne Leerzeichen)" << endl;
    cin >> eingabe;


    cout << "Die urspruengliche Zeichenkette ist: " << eingabe << endl << endl;

    //die Verschl�sselung durchf�hren
    dreher(eingabe);
    asciiKode(eingabe);
    caesar(eingabe);
    gartenzaun(eingabe);

    return 0;
}
