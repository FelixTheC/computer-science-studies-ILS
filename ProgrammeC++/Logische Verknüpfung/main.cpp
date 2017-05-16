#include <iostream>

using namespace std;

int main()
{
    cout << "Logisches UND " << endl;
    cout << "=======================" << endl;
    cout << "1 UND 1\t\t" << (1 && 1) << endl;
    cout << "1 UND 0\t\t" << (1 && 0) << endl;
    cout << "0 UND 1\t\t" << (0 && 1) << endl;
    cout << "0 UND 0\t\t" << (0 && 0) << endl << endl;

    cout << "Logisches ODER" << endl;
    cout << "====================" << endl;
    cout << "1 ODER 1\t" << (1 || 1) << endl;
    cout << "1 ODER 0\t" << (1 || 0) << endl;
    cout << "0 ODER 1\t" << (0 || 1) << endl;
    cout << "0 ODER 0\t" << (0 || 0) << endl << endl;

    cout << "Logisches NICHT" << endl;
    cout << "=================" << endl;
    cout << "NICHT 1\t\t" << !1 << endl;
    cout << "NICHT 0\t\t" << !0 << endl << endl;
    return 0;
}
