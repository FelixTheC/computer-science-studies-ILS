#include <iostream>

using namespace std;

int main()
{
    int A,B,C;
    bool b1,b2,b3,b4;
    b1 = A;
    b2 = B;
    b3 = C;


    /*Da A||B für A oder B steht, ist es nur logisch das !(A||B) für nicht A oder B steht
    das heißt weder noch. Um das etwas anschaulicher dazustellen habe ich diesen Quellcode
    so verfasst*/



    cout << "Gebe bitte A ein und schaue dir an fuer was !(A||B) steht \n";
    cin >> A;
    cout << "Gebe bitte B ein und schau dir an fuer was !(A||B) steht \n";
    cin >> B;
    cout << "\n";
    C = A*2;

    if (b3 == b1 || b2)
        {cout << "Es ist weder A noch B auch nicht A und B sondern C "<< C << endl;
        cout << "Den dafuer steht !(A||B) \n\n";}

        else
            cout << "Gewonnen";

    return 0;
}
