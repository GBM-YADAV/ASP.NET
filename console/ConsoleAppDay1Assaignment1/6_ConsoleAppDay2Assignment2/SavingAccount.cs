using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2Assignment2
{
    internal class SavingAccount : Account
    {
        static public float minimumBalance { get; set; }

        public SavingAccount()
        {
            minimumBalance = 1000.00f;
        }

        public SavingAccount(long accountNo, float accountBalance, string accountPassword) : base(accountNo, accountBalance, accountPassword)
        {
            minimumBalance = 1000.00f;
        }

        public override void withdraw (float Balance)
            {
            accountBalance = accountBalance - Balance;
            Console.WriteLine("your Transaction is successfull ");
            Console.WriteLine("\naccountBalance   :" + accountBalance);
            

        }
        public override void display()
        {
            Console.WriteLine("\nBank Name         :" + SavingAccount.BankName);
            Console.WriteLine("\naccountNo        :" + accountNo);
            Console.WriteLine("\naccountBalance   :" + accountBalance);
            Console.WriteLine("\naccountPassword  :" + accountPassword);
            Console.WriteLine("\nMin bal to be    :" + minimumBalance);
        }
    }
}
