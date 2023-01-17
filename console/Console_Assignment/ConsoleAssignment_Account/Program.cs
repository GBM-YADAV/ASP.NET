using System;

namespace ConsoleAssignment_Account
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ac = new Account(5489632145, " Giri Babu M", " \n \tPayanakandriga \n \tcherlopalli \n \tchitoor\n \t517004", 20000.34);
            Console.WriteLine(ac);
            ac.withdraw(5000.00);
            ac.deposit(40000.00);
            ac.Balance();
            
        }
    }
}
