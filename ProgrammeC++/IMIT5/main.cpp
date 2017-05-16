#include <iostream>
#include <string>
using namespace std;

string verknuepf(bool,bool);

/*####################################################
####Umrechnung von einem Dezimalwert##################
####################################################*/
void Dezi()
{
       int wert, zahl, position= 0;
    int reste[16];
    for (int index=0; index < 16;  index ++)
        reste[index] = 0;
    do {
        cout << "Geben Sie bitte einen Wert ein der umgerechnet werden soll \n";
        cin >> zahl;
        cout << "Mit welcher Basiszahl soll die umrechnung stattfinden?? Zwischen 2 und 9 \n";
        cin >> wert;
    }
     while (zahl > 65535);
     do {
     reste[position] = zahl %wert;
     position++;
     zahl = zahl /wert;
     }
     while (zahl !=0);

     for (int index = 15; index >=0; index--) {
        cout << reste[index];
        if (index % 4 == 0)
            cout << "  ";
     }
}
/*#################################################
######Umrechnung einer Dualzahl####################
#################################################*/
void dual()
{   int zahl;
    int n = 1, position = 0, ergebnis = 0;
    int ziffer[16];

    for (int index = 0; index < 16; index++)
        ziffer[index] = 0;
    do {
    cout << "Geben Sie die Dualzahl ein (max 16 bit):\n";
    cin >> zahl;
    } while (zahl > 1111111111111111);

    do  {
            ziffer[position] = zahl % 10;
            position++;
            zahl = zahl / 10;
    } while (zahl!=0);
    for (int schleife = 0; schleife < 16; schleife++)
    {ergebnis = ergebnis + ziffer[schleife] * n;
    n = n * 2;}

    cout <<"Der Dezimalwert lautet "<< ergebnis << endl;


}
string verknuepf(bool, bool);




int main()
{
    int eingabe;
    int wahl = 4;

    cout << "Felix Berndt \t\t\t\t IMIT5 / 0713 K04 \n";
    cout << "Vertragsnr 800308897 \n\n";
    cout << "Druecken Sie die 1 um die erste Aufgabe aufzurufen \n" << "Druecken Sie die 2 um die zweite Aufgabe aufzurufen \n" << "Druecken Sie die 3 um die dritte Aufgabe aufzurufen\n" << "Druecken Sie die 4 zum beenden" << endl;
    cin >> eingabe,wahl;

    switch(eingabe){

    case 1:
       {
        cout << "Sie haben Aufgabe 1 gewaehlt" << endl;
        bool ergebnis;
    bool ergebnis2;
    bool A = false;
    bool B = true;
    ergebnis = !(A||B);
    ergebnis2= !(A||A);


    cout << std::boolalpha;
    cout << "Die Wahrheitstabelle\n" << endl;
    cout << "A\t\t\tB\t\t\t!(A||B)"<< endl;
    cout <<B<< "\t\t\t"<<B<<"\t\t\t"<< ergebnis << endl;
    cout <<A<<"\t\t\t"<<B<<"\t\t\t"<< ergebnis << endl;
    cout <<B<<"\t\t\t"<<A<<"\t\t\t"<< ergebnis << endl;
    cout << A<<"\t\t\t"<<A<<"\t\t\t"<<ergebnis2 <<endl;

    }
       break;
    case 2:{
        cout << "Sie haben Aufgabe 2 gewaehlt" << endl;
        Dezi();

        }
        break;
    case 3:{
        cout << "Sie haben Aufgabe 3 gewaehlt" << endl;
        dual();
        }
        break;
    case 4:{cout << "Aufwiedersehen";}
    }

        return 0;

}
