using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class Student:Person
    {
        int rolno ;
        int marks;
        int std;
        static int count;

        public Student(int rolno, int marks, int std) : base()
        {
            this.rolno = rolno;
            this.marks = marks;
            this.std = std;
            count++;    
            Console.WriteLine("student");
        }
        public Student(int rolno, int marks, int std,string name,string address,string contact):base(name,address,contact)
        {
            this.rolno = rolno;
            this.marks = marks;
            this.std = std;
            count++;
            Console.WriteLine("student");
        }
        public static void show()
        {
            Console.WriteLine(count);
        }
    }
}
