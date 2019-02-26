using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    
    class BankBranch4
    {
        string name;
        string location;
        string manager;
        BankAccount4[] BankAccounts;
        Customer4[] Customers;

        public BankBranch4()
        {
            name = null;
            location = null;
            manager = null;
            BankAccounts = null;
            Customers = null;
        }

        public string BName
        {
            set { name = value; }
            get { return name; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Manager
        {
            get { return manager; }
            set { manager = value; }
        }
        public BankAccount4[] Bank
        {
            get { return BankAccounts; }
            set { BankAccounts = value; }
        }
        public Customer4[] Customer
        {
            get { return Customers; }
            set { Customers = value; }
        }
    }
}
