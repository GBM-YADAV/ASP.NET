using System;

namespace Console_Function_overLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sum(10, 20);
            Sum(10, 20, 30);
            Sum(10, 20, 20.23657f);
            Sum(10, 20.647576f, 29);
        }
        public static void  Sum(int a, int b)
        {
            Console.WriteLine("{0} + {1} ={2}",a,b,a+b);

        }
        public static void  Sum(int a, int b, int c)
        {
            Console.WriteLine("{0} + {1} + {2}={3}" ,a,b,c, a + b + c);
        }
        public static void  Sum(int a, int b, float c)
        {
        Console.WriteLine("{0} + {1} + {2:F2}={3:F3}" ,a,b,c, a + b + c);



        }
        public static void  Sum(int a, float b, int c)
        {
            Console.WriteLine("{0} + {1:F2} + {2}={3:F2}" ,a,b,c,a + b + c);

        }
    
    }
}
