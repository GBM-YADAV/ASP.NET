using System;

namespace Console_Assignment_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter two values for arithmetic operation");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter \n \n '+' for addition \n '-' for substraction \n '*' for multiplication \n '/' for division\n '%' for modulus division ");
            char c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine("the Sum is :"+(a+b));
                    break;
                case '-':
                    Console.WriteLine("the Difference is :" + (a - b));
                    break;
                case '*':
                    Console.WriteLine("the Product is :" + (a * b));
                    break;
                case '/':
                    Console.WriteLine("the Quotient is :" + (a / b));
                    break;
                case '%':
                    Console.WriteLine("the Remainder  is :" + (a % b));
                    break;
                default:
                    Console.WriteLine("The selected operator is not correct");
                    break;

            }



        }
    }
}
