using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAssignment_Account
{
    internal class Account
    {
        long accountId;
        string Holder_name;
        String address;
        double balance;

        public Account(long acno, string hname,string adre, double bal)
        {
            accountId = acno;
            Holder_name = hname;
            address = adre;
            balance = bal;
        }

        public void withdraw(double amount)
        {
            balance = balance - amount;
            Console.WriteLine("Dear"+Holder_name+"your process is succussfull \n\n                     Balance   => " + balance);
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Dear" + Holder_name + "your process is succussfull \n\n                     Balance   => " + balance);
        }
        public void Balance()
        {
            Console.WriteLine("    Balance :      " + balance);
        }
        public override string ToString()
        {
            return "Account No :  " + accountId + "\nHolder Name :  " + Holder_name + "\nAddress  :  " + address + "\n balance :    " + balance;
        }

    }

}
