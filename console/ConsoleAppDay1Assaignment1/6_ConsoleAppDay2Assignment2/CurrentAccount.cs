using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay2Assignment2
{
    internal class CurrentAccount:Account
    {
         public float overDraftAmount { get; set; }

        public CurrentAccount()
        {
            overDraftAmount = 1000.00f;
        }

        public CurrentAccount(long accountNo, float accountBalance, string accountPassword) : base(accountNo, accountBalance, accountPassword)
        {
            overDraftAmount = 100000.00f;
        }
        public  override void withdraw(float Balance)
        {
            accountBalance = accountBalance - Balance;
            overDraftAmount -= Balance;
            Console.WriteLine("your Transaction is successfull ");
            Console.WriteLine("\naccountBalance   :" + accountBalance);
            Console.WriteLine("\nover Draft Amount :" + overDraftAmount);
        }
        public override void display()
        {
            Console.WriteLine("\nBank Name         :" + CurrentAccount.BankName);
            Console.WriteLine("\naccountNo        :" + accountNo);
            Console.WriteLine("\naccountBalance   :" + accountBalance);
            Console.WriteLine("\naccountPassword  :" + accountPassword);
            Console.WriteLine("\nover Draft Amount :" + overDraftAmount);
        }

       
    }
}
