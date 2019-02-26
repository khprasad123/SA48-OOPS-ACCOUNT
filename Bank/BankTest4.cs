using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankTest4
    {
        static void Main()
        {
            BankBranch4 B1 = new BankBranch4("DBS", "Singapore", "Harirpasad");

            Customer4 C1 = new Customer4("hariprasad", "kottarathil", 23);

            B1.AddCustomer(C1);
            B1.AssignAccount(C1);

            Customer4 C2 = new Customer4("Kannan", "kottarathil", 25);
            Customer4 C3 = new Customer4("dsadas", "kottarathil", 54);
            Customer4 C4 = new Customer4("gfdgdf", "kottarathil", 90);
            Customer4 C5 = new Customer4("vcxv", "kottarathil", 78);
            Customer4 C6 = new Customer4("plplp", "kottarathil", 12);
         

            B1.AddCustomer(C2);
            B1.AddCustomer(C3);
            B1.AddCustomer(C4);
            B1.AddCustomer(C5);
            B1.AddCustomer(C6);

           



            B1.AssignAccount(C2);
            B1.AssignAccount(C3);
           

            B1.Deposite(C1, 500);
            B1.Deposite(C2, 6980);
            B1.CreditInterest(C1);
           
            B1.PrintAllCustomer();
            B1.PrintAllAccountDetails();

            B1.TransferMoney(C1, C2, 65);
            B1.PrintAllAccountDetails();
        }
    }
}
