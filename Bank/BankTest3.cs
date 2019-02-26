using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankTest3
    {
        static void Main()
        {
            BankAccount3 B1 = new BankAccount3();
            B1.Deposite(1200);
            B1.PrintCustomerData();

            Console.WriteLine(B1.Joint.Name);
            
        }
    }
}
