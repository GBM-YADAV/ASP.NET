using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2Assignment2
{
    internal abstract class Account
    {
        static public String BankName = "State Bank Of India";

        public long accountNo { get; set; }

        public float accountBalance { get; set; }

        public String accountPassword { get; set; }

        public Account()
        {
            accountNo = 99631914228;
            accountBalance = 19000.45f;
            accountPassword = "Giri@12Babu@123";

        }
        public Account(long accountNo, float accountBalance, string accountPassword)
        {
            this.accountNo = accountNo;
            this.accountBalance = accountBalance;
            this.accountPassword = accountPassword;
        }

        public abstract void withdraw(float Balance);

        public virtual void display()
        {
            Console.WriteLine("\nBank Name         :" + Account.BankName);
            Console.WriteLine("\naccountNo        :" + accountNo);
            Console.WriteLine("\naccountBalance   :" + accountNo);
            Console.WriteLine("\naccountPassword  :" + accountNo);
        }
    }
}
