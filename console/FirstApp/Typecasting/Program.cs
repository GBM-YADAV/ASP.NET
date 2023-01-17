using System;

namespace Typecasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short s = 125;
            int i = s; // no need of explicit casting 
            long l = i; // no need of explicit casting 

            float f = 4.5f;
            double d = f;//no need of explicit casting 

            float g = i; //no need of explicit casting 
            //but

            // down casting

            int k = (int)f;  // it needs type casting becaus eof decimal values are loosed
            long h = 1234;
            int n = (int)h;    // explicit conversion required
            short S = (short)n;  // explicit conversion required

            Console.WriteLine(k);

            string str = "125";
            int num = Convert.ToInt32(str);
            int num1 = Convert.ToInt16(str);
            long num2 = Convert.ToInt64(str);
            float num3= Convert.ToSingle(str);
            double num4 = Convert.ToDouble(str);
            decimal num5 = Convert.ToDecimal(str);

            int n1 = Int32.Parse(str);
            long n2 = Int64.Parse(str);
            Console.WriteLine(num3);

            Object data = 10;
            Object data1 = "hello";
            Object data2 = 10.55f;
            Object data3 = 1234.45m;
            Object data4 = true;

            int nu1 = (int)data;
            float nu2 = (float)data2;
            bool nu3 = (bool)data4;

            Console.WriteLine(nu1);
            Console.WriteLine(nu3);
            Console.WriteLine(data3);

            //Nullable types
            Nullable<double> d2= null; 
            double? d3 = null; //shortcut syntax



            double? val = GetMyValue();
            if (val.HasValue)
            {
                Console.WriteLine($"Value of double is {val.Value}");
            }
            else
            {
                Console.WriteLine("Null is returned");
            }
        }
        //this function may return a double value or null
        static double? GetMyValue()
        {
            //return 65959.00;
            return null;
        }
    }
   
}
