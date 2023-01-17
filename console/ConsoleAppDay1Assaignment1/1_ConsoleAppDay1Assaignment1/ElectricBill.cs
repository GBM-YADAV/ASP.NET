using System;

namespace ConsoleAppDay1Assaignment1
{
    internal class ElectricBill
    {
        static void Main(string[] args)
        {
            decimal StanderedPrice= 1.20m;
            Console.WriteLine("rnter the number of units ");
            decimal NoUnits=Convert.ToDecimal(Console.ReadLine());
            

            if(NoUnits<100)
            {
                Console.WriteLine("the bill is:{0:f2}",NoUnits * StanderedPrice);
            }
            else if(NoUnits <= 300)
            {
                Console.WriteLine("the bill is:{0:f2}",  120+(NoUnits - 100)*(2));
            }
            else
            {
                Console.WriteLine("the bill is:{0:f2}", 120 +400+ (NoUnits - 300) * (3));
            }

        }
    }
}
