using System;

namespace ConsoleAppDay2Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount account = new SavingAccount();
            account.display();

            account.withdraw(500.00f);
            account.display();

            CurrentAccount account1 = new CurrentAccount(69587426894, 50000.45f, "hlohi@sbi");
            account1.display();
            account1.withdraw(1000.89f);
            account1.display();
        }
    }
}
