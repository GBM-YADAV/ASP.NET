using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Interface
{
    internal class Student:Iprintable
    {
        public  int marks{ get; set; }
        public String name { get; set; }
        public int id { get; set; }
        public int resultmonth { get; set; }

        public void print()
        {
            if (marks >= 50)
                Console.WriteLine(" id: "+id+" name"+name+"result: pass");
            else
                Console.WriteLine("id: \"+id+\" name"+name+"result:Fail");
        }

        public void showDate()
        {
            Console.WriteLine("the result month is :"+DateTime.Now.Month); ;
        }
    }
}
