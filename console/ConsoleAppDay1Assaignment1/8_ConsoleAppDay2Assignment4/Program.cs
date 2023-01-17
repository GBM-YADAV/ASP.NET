using System;

namespace ConsoleAppDay2Assignment4
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException(string msg) : base(msg)
        {

        }


    }
    internal class InSufficientFundException:Exception
    {
        public InSufficientFundException(string msg) : base(msg)
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                withdraw(20000);
            }
            catch (InvalidAmountException e) { Console.WriteLine(e.Message); }
            catch (InSufficientFundException e) { Console.WriteLine(e.Message); }


        }

        static void withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new InvalidAmountException("sorry the amount cant be negative");
            }

            else if (amount > 10000)
            {
                throw new InSufficientFundException("sorry the amount is insuficient ");
            }
        }
    }

}

