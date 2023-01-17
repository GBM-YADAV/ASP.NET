using System;

namespace ConsoleExeptionHAndling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            try
            {
                Console.WriteLine("enter a number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a number");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, c);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch(FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch(DivideByZeroException ep)
            //{
            //    Console.WriteLine(ep.Message);
            //}
            //catch(OverflowException ox)
            //{
            //    Console.WriteLine(ox.Message);
            //}
           
        }
    }
}
