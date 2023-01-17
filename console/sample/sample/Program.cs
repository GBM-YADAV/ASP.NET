
using System;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the depth of weell");
            int a=Convert.ToInt32(Console.ReadLine());
            int height = 0;
            int days = 0;
            while(height<a)
            {
                height += 7;
                if(height<a)
                {
                    height -= 2;
                }
                days++;
            }

            Console.WriteLine("the dyas took to be out of the well is:"+days);
        }
    }
}
