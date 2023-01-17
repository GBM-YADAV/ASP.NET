using System;
using System.Collections.Generic;
using System.Text;

namespace Non_generic_collection
{ 
    internal class Student
    {
        int rolno ;
        int marks;
        int std;
        static int count;

        public Student(int rolno, int marks, int std) 
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
