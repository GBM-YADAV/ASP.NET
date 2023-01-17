using System;

namespace Console_Assignment_params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Friends("Giri", "Vamsi", "Vherry", "Mohana", "Deepthi", "Akhi", "Mounika", "Dharshan", "Bhavana");
        }

        public static void Friends( params string[] names)
        {
            Array.Sort(names);
            Console.WriteLine("the list of all my best friends is as fllows :-");

            foreach (string n in names)
            {
                Console.WriteLine("=>" + n);
            }
        }
    }
}
