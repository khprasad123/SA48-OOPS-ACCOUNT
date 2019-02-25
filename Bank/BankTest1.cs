using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankTest1
    {
        static void Main(string[] args)
        {
            BankAccount1 A1 = new BankAccount1();
            Console.WriteLine(A1.Acc_No);
            Console.WriteLine(A1.Balance);
            A1.Deposite(1000);
            Console.WriteLine(A1.Balance);
            A1.Withdraw(64);
            Console.WriteLine(A1.Balance);
            A1.CreditInterest();
            Console.WriteLine(A1.Balance);
            Console.WriteLine(A1.Name);
            Console.WriteLine(A1.State);

            BankAccount1 A2 = new BankAccount1("hariprasd",700);
            Console.WriteLine(A2.Acc_No);
            Console.WriteLine(A2.Balance);
            A2.Deposite(1000);
            Console.WriteLine(A2.Balance);
            A2.Withdraw(64);
            Console.WriteLine(A2.Balance);
            A2.CreditInterest();
            Console.WriteLine(A2.Balance);
            Console.WriteLine(A2.Name);
            Console.WriteLine(A2.State);


        }
    }
}
