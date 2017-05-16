/*###############################################################
######  while Schleife von 1 bis 10 #############################
###############################################################*/

#include <iostream>

using namespace std;

int main()
{
    int zahl = 1;
    // die Schleife
    while (zahl <= 10) // der Schleifenkopf
        { cout<< zahl << endl;    // der Schleifenkörper
        zahl++; }
    return 0;
}
