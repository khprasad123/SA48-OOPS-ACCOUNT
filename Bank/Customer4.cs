using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer4
    {
        string name;
        string address;
        string IC_number;
        int age;

        public Customer4() { name = "null"; address = "null"; IC_number = "null"; age = 18; getValues(); } //default
        public Customer4(string type) ///for joint account
        {
            name = "null"; address = "null"; IC_number = "null"; age = 18;
        }
        public string Name
        {
            get { return name; }
        }
        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        public string IC_Number
        {
            get { return IC_number; }
            set { IC_number = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void getValues()
        {
            Console.Write("\n\tEnter your name : ");
            name = Console.ReadLine();
            Console.Write("\n\tEnter your address : ");
            address = Console.ReadLine();
            Console.Write("\n\tEnter your ic : ");
            IC_Number = Console.ReadLine();
            Console.Write("\n\tEnter your Age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("\n\n");
        }
       
    }
}
