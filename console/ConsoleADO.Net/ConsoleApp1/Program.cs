using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 213, 5, 89 };
            Array.Sort(ar);

            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(ar);
            foreach (int i in ar)
            {
                Console.WriteLine(i);
            }
        }
    }
}
