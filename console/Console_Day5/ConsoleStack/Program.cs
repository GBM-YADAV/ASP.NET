using System;
using System.Collections;

namespace ConsoleStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Stack mystack =new Stack();
            mystack.Push(12);
            mystack.Push("giri");

            try
            {
                Console.WriteLine(mystack.Pop());
                Console.WriteLine(mystack.Pop());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            
            Queue myq = new Queue();
            myq.Enqueue(42);
            myq.Enqueue("hloooke hi");
            myq.Dequeue();

            Console.WriteLine(myq.Contains(42));


            Hashtable mytable = new Hashtable();
            mytable.Add(1, "one");
            mytable.Add(2, "two");
            mytable.Add(3, "three");




        }
    }
}
