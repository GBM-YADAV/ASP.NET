using System;

namespace Console_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 100, y = 200;
            //Console.WriteLine("before swap : x=" + x + " , y= " + y) ;
            //swap(ref x, ref y);
            //  Console.WriteLine("after swap : x=" + x + " , y= " + y);
            //int  ar;
            //int length;
            //int breadth;
            //Console.WriteLine("enter the length of a rectangle ");
            //length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the breadth of a rectangle");          
            //breadth = Convert.ToInt32(Console.ReadLine());
            //area( length, breadth, out ar);
            //Console.WriteLine("Area of the circle ={0:f2}",ar);

            members(1055, "durga", "giri", "kiruthika");
            members(1055, "A", "B", "C", "D", "E", "F", "G", "H", "I");
        }

        

        //public static void area( int l,int b,out int A)
        //{
        //    A = l*b;
        //}
        ////params key word is used to pass an array of undecided length of as a parameter

        public static void members(int brcode,params string[] names)
        {
            Console.WriteLine("branch code is "+brcode);

            foreach(string n in names)
            {
                Console.WriteLine("name : "+n);
            }
        }

    }
}
