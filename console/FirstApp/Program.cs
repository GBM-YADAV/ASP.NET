using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Giri Babu";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            
            Console.WriteLine(name.Substring(0,5));
            Console.WriteLine(name.Substring(5));
            Console.WriteLine(name.Replace("Giri","Manjalam"));
            Console.ReadKey();
        }
       
    }
}
