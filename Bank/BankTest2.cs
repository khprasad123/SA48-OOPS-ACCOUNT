using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankTest2
    {
        static void Main()
        {
            BankAccount2 B1 = new BankAccount2();
            B1.Deposite(1200);
            B1.PrintCustomerData();
           
            BankAccount2 B2 = new BankAccount2();
            B1.Transfer(B2, 100);
            B2.PrintCustomerData();
        }
    }
}
