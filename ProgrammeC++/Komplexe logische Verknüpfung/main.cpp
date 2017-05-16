#include <iostream>

using namespace std;

int main()
{
    bool links, rechts, ergebnis;
    cout << "links" << endl;
    cout << "==============" << endl;
    links = 1 && 1;
    cout << "links" << endl;
    cout << "rechts" << endl;
    cout << "=============" << endl;
    rechts = 1 && !(1) ;
    cout << "rechts" << endl;
    cout << "ergebnis" << endl;
    cout << "============" << endl;
    ergebnis = links || rechts;
    cout << "ergebnis" << endl;
    return 0;
}
