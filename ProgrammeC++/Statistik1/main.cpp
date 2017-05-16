#include <iostream>

#include <limits> // für die Ermittlung des größten int-Wertes

using namespace std;

int main()
{
    //die Vereinbarung der Variablen
    int maximum, minimum, eingabe=0, summe=0, anzahlEingaben =0;
    float mittelwert;

    //das vorläufige Maximum und Minimum setzten
    // das Minimum ist der größte Wert für int
    minimum = numeric_limits<int>::max();
    maximum = numeric_limits<int>::min();
    //die Werte einlesen
    do {
        cout<< "Geben sie die" << anzahlEingaben +1 << ".Zahl ein: ";
        cin >> eingabe;

        //wurde ein Wert ungleich 0 eingegeben??

        if (eingabe !=0){
            //haben wir ein neues minimum
            if (eingabe < minimum)
                minimum = eingabe;
            // haben wir ein neues maximum
            if (eingabe > maximum)
                maximum = eingabe;
            // die Anzahl der Eingabe erhöhen
            anzahlEingaben ++;
            // und die Eingaben zusammenrechnen
            summe=summe + eingabe;
        }
    } while (eingabe !=0);

    // ist mindestens eine Zahl eingegeben worden?
    if (anzahlEingaben !=0){
        //den Mittelwert berechnen
        //dabei muss einer der ganzzahligen Werte gecastet werden
        mittelwert=summe/static_cast<float>
        (anzahlEingaben);

        // die Werte ausgeben

        cout<< "Sie haben"<< anzahlEingaben << "Werte eingegeben"<< endl;
        cout<< "Die Summe der Werte ist; "<< summe << endl;
        cout<< "Das minimum ist: "<< minimum <<endl;
        cout<< "Das maximum ist: "<< maximum << endl;
        cout<< "Der Mittelwert lautet: "<< mittelwert<<endl;
        }
    return 0;
}
