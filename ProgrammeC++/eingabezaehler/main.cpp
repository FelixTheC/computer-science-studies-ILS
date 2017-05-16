#include <iostream>

using namespace std;

int main()
{
    string eingabe = "";
    cout << "Bitte geben Sie ein Wort ein" << endl;
    cin >> eingabe;
    cout << endl;

    for(int i = 0; i < eingabe.size(); ++i)
        {cout << eingabe <<endl;}

    return 0;
}
