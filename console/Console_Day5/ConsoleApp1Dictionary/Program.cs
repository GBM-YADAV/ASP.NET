using System;
using System.Collections.Generic;

namespace ConsoleApp1Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> numbers = new Dictionary<String, string>();
            numbers.Add("andhra", "amaravathi");
            numbers.Add("tamil nadu", "chennai");
            numbers.Add("Karnataka", "banglore");
            Console.WriteLine(numbers["andhra"]);
            Console.WriteLine(numbers.Count);
            foreach (var kvp in numbers)
            {
                Console.WriteLine("key is     " + kvp.Key + "     alue is     " + kvp.Value);
            }
            Console.WriteLine("karnataka is present:" + numbers.ContainsKey("karnataka"));
            Console.WriteLine("amaravathi is present:" + numbers.ContainsValue("amaravathi"));
             

            SortedDictionary<int,string> mydic=new SortedDictionary<int,string>();
            mydic.Add(1, "india");
            mydic.Add(2, "usa");
            mydic.Add(3, "usa");
            mydic.Add(4, null);

            Console.WriteLine(mydic.ContainsValue("india"));


        }
    }
}