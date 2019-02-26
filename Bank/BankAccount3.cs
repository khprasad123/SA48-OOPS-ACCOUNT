using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount3
    {
        static int account_no = 1000; //common memmory for all
        Customer3 AccountHolder = new Customer3();
        Customer3 JointHolder;
        double balance;
        string state;
        double interest; //put as a fixed number for ease of use  7% per annum

        public Customer3 Cus
        {
            get { return AccountHolder; } //only need for gettig the values
        }
        public Customer3 Joint
        {
            get { return JointHolder; } //only need for gettig the values
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
        public BankAccount3()
        {
            account_no += 1;
            balance = 0;
            state = "OPEN";
            interest = 0.07;
            Console.WriteLine("Creating an account   ------> \n");
            Console.Write("Want a Joint Account Holder --press 1 to make :");
            JointHolder = new Customer3("Joint");
            if (Console.ReadLine() == "1")
            {
                JointHolder = new Customer3();
            }

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
            Console.WriteLine("\t\t\tInterst Credited $" + (balance * interest));
        }
        public void PrintCustomerData()
        {
            Console.WriteLine("\n\n\tAccount No : ".PadRight(20, ' ') + account_no);
            Console.WriteLine("\tName : ".PadRight(20, ' ') + Cus.Name);
            Console.WriteLine("\tAddress : ".PadRight(20, ' ') + Cus.Address);
            Console.WriteLine("\tAge : ".PadRight(20, ' ') + Cus.Age);
            Console.WriteLine("\tIC Number : ".PadRight(20, ' ') + Cus.IC_Number);
            Console.WriteLine("\tBalance : ".PadRight(20, ' ') + "$" + balance);
            Console.WriteLine("\tAccount state now is ".PadRight(20, ' ') + state + "\n\n");

        }
        public bool Transfer(BankAccount3 A, double money)
        {
            bool k = this.Withdraw(money);
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
