using System;

namespace Practice_Session
{
    internal class Program
    {
        int a;
        
        static void Main(string[] args)
        {
            student stu = new student();
            Console.WriteLine("enter your rollno");
            int b = Convert.ToInt32(Console.ReadLine());
            int a =stu.display();
            Console.WriteLine(a);
        }
        

    }

    internal class student
    {

        int rollno;
        public int  display(int a)
        {
            int rollno =  ;
            return rollno;
        }

        public void show()
        {
            Console.WriteLine(rollno);
        }
    }
}


returntype fucname(int a,int b,int c....)
{

}