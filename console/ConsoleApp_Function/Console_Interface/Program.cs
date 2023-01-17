using System;

namespace Console_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car() { model = "BMW", brand = "maryti", Man_year = 2022 };
            mycar.print();
            mycar.showDate();

            Student stu = new Student() { id = 1, name = "giri", marks = 96, resultmonth = 5 };
            stu.print();
            stu.showDate();
            
        }
    }
}
