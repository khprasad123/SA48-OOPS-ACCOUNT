using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{  
    class BankAccount1
    {
        static int account_no=1000; //common memmory for all
        string name;
        double balance;
        string state;
        double interest; //put as a fixed number for ease of use  7% per annum

        public int Acc_No
        {
            get { return account_no; }
        }/////c# properties
        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        ////account number only used for getting;
        ///
        public BankAccount1() { account_no +=1 ;name = "null";balance = 0;state = "closed";interest = 0.07; } ///default Constructor
        public BankAccount1(string name, double balance):this()  
        {
            this.name=name;
            this.balance = balance;
            this.state = "open";  //after creating an account with correct name it will be opened
        }

        ///below are services
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
        public void Deposite(int amount)
        {
            balance += amount;
        }

        public void CreditInterest()
        {
            balance = balance + (balance * (interest)); //already fixed the interest
        }

    }
}
