using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount2
    {
        static int account_no = 1000; //common memmory for all
        Customer Human=new Customer();
        double balance;
        string state;
        double interest; //put as a fixed number for ease of use  7% per annum

        public Customer Cus
        {
            get { return Human; } //only need for gettig the values
        }
        public int Acc_No
        {
            get { return account_no; }
        }/////c# properties
        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        ////account number only used for getting;
        ///
        public BankAccount2() {
            account_no += 1;
            balance = 0;
            state = "OPEN";
            interest = 0.07;
            Console.WriteLine("Creating an account   ------> ");
            Human.getValues();
        } ///default Constructor
        public bool Withdraw(double amt)
        {
            if (balance > amt)
            {
                balance -= amt;
               // Console.WriteLine("\t\t\tWithdraw Succeed ");
                return true;
            }
            Console.WriteLine("\t\t\tInsufficient Funds ");
            return false;
        }
        public void Deposite(double amount)
        {
            balance += amount;
        }

        public void CreditInterest()
        {
            balance += balance * interest;
            Console.WriteLine("\t\t\tInterst Credited $"+ (balance*interest));
        }
        public void PrintCustomerData()
        {
            Console.WriteLine("\n\n\tAccount No : ".PadRight(20, ' ') + account_no);
            Console.WriteLine("\tName : ".PadRight(20, ' ') + Cus.Name);
            Console.WriteLine("\tAddress : ".PadRight(20, ' ') + Cus.Address);
            Console.WriteLine("\tAge : ".PadRight(20, ' ') + Cus.Age);
            Console.WriteLine("\tIC Number : ".PadRight(20, ' ') + Cus.IC_Number);
            Console.WriteLine("\tBalance : ".PadRight(20, ' ') +"$"+ balance);
            Console.WriteLine("\tAccount state now is ".PadRight(20,' ') + state+"\n\n");

        }
        public bool Transfer(BankAccount2 A,double money)
        {
            bool k= this.Withdraw(money);
            if (k)
            {
                A.Deposite(money);
                Console.WriteLine("Transfer Succeeded");
                return k;
            }
            Console.WriteLine("Transfer Failed");
            return k;
        }
    }
}
