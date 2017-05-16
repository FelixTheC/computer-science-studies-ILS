/*#########################################
########## for Schleife ###################
#########################################*/

#include <iostream>

using namespace std;

int main()
{   int zahl;
    for (zahl =0; zahl <=10; zahl++)
    cout<< zahl << "\n\n";

    cout<< "Und nun in die andere richtung";

    for (zahl =10; zahl >=1; zahl--)
        cout<< zahl << "\n\n";

    return 0;
}
