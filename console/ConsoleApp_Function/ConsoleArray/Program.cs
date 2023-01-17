using System;

namespace ConsoleArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[4];
            fruits[0] = "banana";
            fruits[1] = "Apple";
            fruits[2] = "Mango";
            fruits[3] = "Grapes";

            Console.WriteLine("Given array is :-");

            for(int i=0;i<4;i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Array.Reverse(fruits);
            Console.WriteLine("using foreach loop");

            foreach( string s in fruits)
            {
                Console.WriteLine(s);
            }
            int[] marks = { 12, 34, 45, 23, 56, 56 };
            Array.Sort(marks);
            Console.WriteLine("display of marks");
            for(int i=0; i<marks.Length;i++)
            {
                Console.WriteLine("marks :" + marks[i]);
            }


        }
    }
}
