using System;

namespace ConsoleAppDay1Assaignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.display();

            Account account1 = new Account(69587426894,50000.45f,"hlohi@sbi");
            account1.display();

        }
    }
}
