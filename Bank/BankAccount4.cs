using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount4
    {
        static int count = 1;
        int account_no = 1; //common memmory for all
        Customer4 AccountHolder;
        Customer4 JointHolder;
        double balance;
        string state;
        double interest; //put as a fixed number for ease of use  7% per annum

        public Customer4 Cus
        {
            get { return AccountHolder; } //only need for gettig the values
        }
        public Customer4 Joint
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
        public BankAccount4(Customer4 NewCustomer)
        {
                JointHolder = null;
                account_no += count++;
                balance = 0;
                state = "OPEN";
                interest = 0.07;
                AccountHolder = NewCustomer;
            Console.WriteLine("Creating an account   ------> done\n");
        } ///default Constructor
        public void addJoint(Customer4 NewCustomer)
        {
            JointHolder = NewCustomer;
            Console.WriteLine("Converting as Joint account   ------> done\n");
        }
        public bool Withdraw(double amt)
        {
            if (balance > amt)
            {
                balance -= amt;
                // Console.WriteLine("\t\t\tWithdraw Succeed ");
                return true;
            }
            return false;
        }
        public void Deposite(double amount)
        {
            balance += amount;
        }

        public void CreditInterest()
        {
            balance += balance * interest;
            Console.WriteLine("\t\t\tInterst Credited $" + (balance * interest) +"\n\t\t\tFinal Balance : "+balance);
        }
        public void PrintAccountData()
        {
            Console.WriteLine("\n\n\tID No : ".PadRight(20, ' ') + AccountHolder.CID);
         //   Console.WriteLine("\n\n\tID No : ".PadRight(20, ' ') + Joint.CID);
            Console.WriteLine("\tAccount No : ".PadRight(20, ' ') + account_no);
            Console.WriteLine("\tOwner : ".PadRight(20, ' ') + Cus.Name);
            Console.WriteLine("\tAddress : ".PadRight(20, ' ') + Cus.Address);
            Console.WriteLine("\tAge : ".PadRight(20, ' ') + Cus.Age);
            Console.WriteLine("\tBalance : ".PadRight(20, ' ') + "$" + balance);
            Console.WriteLine("\tAccount state now is ".PadRight(20, ' ') + state + "\n\n");

            if (JointHolder!=null)
            {
                Console.WriteLine("\nYour Joint Holder");
                Console.WriteLine("\n\n\tID No : ".PadRight(20, ' ') + JointHolder.CID);
                Console.WriteLine("\tJoint Owner : ".PadRight(20, ' ') + JointHolder.Name);
                Console.WriteLine("\tAddress : ".PadRight(20, ' ') + JointHolder.Address);
                Console.WriteLine("\tAge : ".PadRight(20, ' ') + JointHolder.Age);
            }

        }
        public bool Transfer(BankAccount4 A, double money)
        {
            bool k = this.Withdraw(money);
            if (k)
            {
                A.Deposite(money);
                Console.WriteLine("Transfer Succeeded");
                return k;
            }
            return k;
        }
    }
}
