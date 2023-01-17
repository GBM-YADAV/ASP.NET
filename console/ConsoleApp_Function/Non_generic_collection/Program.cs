using System;
using System.Collections;

namespace Non_generic_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList mylist = new ArrayList();
            //int[] myarray = new int[];
            mylist.Add(12);
            mylist.Add(28.98f);
            mylist.Add(3.567);
            mylist.Add(Math.PI);
            mylist.Add(DateTime.Now);
            mylist.Add("LTI");
            mylist.Add(new Student(1,3,5));
            var w = 6;

            foreach(var obj in mylist)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
