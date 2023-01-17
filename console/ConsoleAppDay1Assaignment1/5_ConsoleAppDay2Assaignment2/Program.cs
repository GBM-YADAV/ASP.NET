using System;

namespace ConsoleAppDay2Assaignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount account = new SavingAccount();
            account.display();

            CurrentAccount account1 = new CurrentAccount(69587426894, 50000.45f, "hlohi@sbi");
            account1.display();

        }
    }
}
