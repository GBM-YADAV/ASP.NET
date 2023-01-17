using System;
using System.Collections.Generic;
using System.Text;

namespace Console_class_object
{ 
   public static  class MyMath
    {
        public static int n1;
        public static int n2;


        static MyMath()
        {
            Console.WriteLine("its a static class so intialization is automatic");
            n1 = 10;
            n2 = 20;
        }
        public static void sum()
        {
            Console.WriteLine("sum +"+(n1+n2));
        }
        public static void multiply()
        {
            Console.WriteLine("Product+" + (n1 * n2));
        }
        public static void sub()
        {
            Console.WriteLine("diference+" + (n1 - n2));

        }
        public static void dev()
        {
            Console.WriteLine("quotiont +" + (n1 / n2));
        }
    }
}
