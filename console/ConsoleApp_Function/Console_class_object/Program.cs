
using System;

namespace Console_class_object
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //data d1 = new data();
            //d1.setDay(5);
            //d1.setMonth(6);
            //d1.setYear(2001);
            //int a = d1.getDay();
            //int b = d1.getMonth();
            //int c = d1.getYear();
            //Console.WriteLine("{0}-{1}-{2}",d1.getDay(),d1.getMonth(),d1.getYear());


            //Class1 marks = new Class1(70, 92, 82);

            //Console.WriteLine(marks);
            //Employee emp = new Employee();

            //DateTime date = DateTime.Now;
            //Employee emp1 = new Employee(2, "hari", "prasad", dept.it, 4000.34f, date);
            //Console.WriteLine(emp);
            //Console.WriteLine(emp1);
            //Employee[] emparray = new Employee[3];
            //emparray[0] = new Employee(3, "vamsi", "kumar", dept.it, 45000.34f, date);
            //emparray[1] = new Employee(4, "cheri", "kolandi", dept.it, 60000.34f, date);
            //emparray[2] = new Employee(5, "Giri", "babu", dept.it, 500.34f, date);

            //Employee.showcount();
            //Employee.ShowGrossSalary(emp);

            Daughter d = new Daughter();
            Console.WriteLine(d);
            Daughter d1 = new Daughter("getha", 27, "mummy", 45);
            Console.WriteLine(d1);
            //MyMath.sum();
            //MyMath.sub();
            //MyMath.dev();
            //MyMath.multiply();

        }
    }
}
