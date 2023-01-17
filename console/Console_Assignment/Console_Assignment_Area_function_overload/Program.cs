using System;

namespace Console_Assignment_Area_function_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area(10, 20);
            Area(30);
            Area(5, 6, 7);
        }
        public static void Area(int length,int breadth)
        {
            Console.WriteLine(" the Area for the rectangle is : "+(length*breadth));
        }
        public static void Area(int radius)
        {
            Console.WriteLine(" the Area for the circle is : {0:f2}" , (Math.PI*radius*radius));
        }
        public static void Area(int s1,int s2,int s3)
        {
            float s = (s1 + s2 + s3) / 2;
            Console.WriteLine(" the Area for the triangle  is : {0:f2}" , (Math.Sqrt(s*(s-s1)*(s-s2)*(s-s3))));
        }
    }
}
