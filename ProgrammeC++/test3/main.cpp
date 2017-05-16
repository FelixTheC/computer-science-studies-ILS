#include <iostream>
#include <string>
using namespace std;
string verknuepf(bool,bool);        // Der Funktionsprototyp

int main()
{   bool ergebnis;
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

    return 0;

}

