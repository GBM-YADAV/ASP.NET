using System;

namespace Console_Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[4];
            stu[0] = new Student() { rollno = 844, name = "giri" };
            stu[1] = new Student() { rollno = 14, name = "vamsi" };
            stu[2] = new Student() { rollno = 73, name = "hari" };
            stu[3] = new Student() { rollno = 34, name = "mouni" };
            Array.Sort(stu);
            int output = stu[0].CompareTo(stu[1]);
            Console.WriteLine(output);
            foreach (Student student in stu)    
                Console.WriteLine(student.name+" "+student.rollno);
        }
    }
}
