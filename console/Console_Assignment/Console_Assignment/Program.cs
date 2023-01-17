using System;

namespace Console_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int base_Length;
            int height;
            double area;
            Console.WriteLine("enter the value for base of the triangle");
            base_Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value for height of the triangle");
            height = Convert.ToInt32(Console.ReadLine());
            Area(ref base_Length, ref height, out area);
            Console.WriteLine("The area of the triangle is : "+area);

        }

        public static void Area(ref int ba ,ref int hi,out double A )
        {
            int a= 0.5 * ba * hi;
        }
    }
}
