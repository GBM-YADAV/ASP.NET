using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                f1();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);// the error msg
                Console.WriteLine(ex.StackTrace);//stack tree line numbers where error is found 
                Console.WriteLine(ex.Source); // source of error
            }
        }
        public static void f1()
        {
            f2();
        }
        public static void f2()
        {
            f3();
        }
        public static void f3()
        {
            int a = 10, b = 0;
            int c = a / b;
            Console.WriteLine();
        }
    }
}
