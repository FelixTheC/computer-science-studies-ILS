#include <iostream>
#include <sstream>
using namespace std;
//base class
class Employee {
    //um im der abgeleiteten Klasse auf pay zugreifen zukönnen protected statt private
protected:
    string name;
    double pay;
public:
    Employee(){
    name = "";
    pay = 0;
    }
    Employee(string empName, double payRate) {
    name = empName;
    pay = payRate;
    }
    string getName(){
    return name;
    }
    void setName(string empName) {
        name = empName;
    }
    double getPay(){
    return pay;
    }
    void setpay(double payRate) {
        pay = payRate;
    }
    //damit das hier funktioniert muss #include <sstream> oben eingefügt werden
    string toString() {
        //eine Instanz vom stringstream erzeugen
        stringstream stm;
        //namen und 'gehalt' zusammen ausgeben
        stm << name << ": " <<pay;
        return stm.str();
    }

    double grossPay(int hours)
    {
        return pay*hours;
    }
};

//abgeleitete Klasse

class Manager : public Employee {
private:
    bool salaried;

public:
    Manager(string name, double payRate, bool isSalaried): Employee(name, payRate)
    {
        salaried = isSalaried;
    }
    bool getSalaried() {
    return salaried;
    }

    double grossPay(int hours) {
        if(salaried){
            return pay;
        }
        else{
    return pay * hours;
        }
    }

     string toString() {
        stringstream stm;
        string salary;
        if(salaried){
            salary = "Salaried";
        }else{
        salary = "Hourly";
        }
        stm << name << ": " <<pay << ": "<<salary<<endl;
        return stm.str();
    }
};
int main()
{
    //Instanz erzeuugen um dann damit zuarbeiten
    Employee emp1 ("Jane Smith",35000);
    Employee emp2 ("Bill Brown",42000);
    cout << emp1.toString()<<endl;
    cout << emp2.toString()<<endl;
    Employee emp3("Mary Smith", 15.00);
    cout << "Employee name: " <<emp3.getName()<<endl;
    cout << "Employee pay rate: "<<emp3.getPay()<<endl;
    cout << "Employee gross Pay: "<<emp3.grossPay(40)<<endl;
    Manager emp4("Bob Brown", 1500, true);
    cout << "Employee Name "<< emp4.getName()<<endl;
    cout << "Employee pay rate: "<<emp4.getPay()<<endl;
    cout << "Emp4 Salaried? "<< emp4.getSalaried()<<endl;
    cout <<"Emp4 gross pay: "<<emp4.grossPay(40)<<endl;
    return 0;
}
