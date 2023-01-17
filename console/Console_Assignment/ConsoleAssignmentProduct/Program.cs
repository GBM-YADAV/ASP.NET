using System;

namespace ConsoleAssignmentProduct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            Product product = new Product();
            Product product1 = new Product(1002,"phone",10000.23f,d,category.e);
            Console.WriteLine(product);
            Console.WriteLine(product1);
        }
    }
}
