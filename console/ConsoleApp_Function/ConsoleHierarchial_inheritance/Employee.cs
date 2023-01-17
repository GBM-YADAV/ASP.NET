using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Employee
    {
        public String name;
        public Double basic_sal;

        public Employee(string s,double d)
        {
            name = s;
            basic_sal = d;
        }
        public  void GrossSal()
        {
            Console.WriteLine("the gross salary is:{0:f2}",basic_sal+0.2*basic_sal);
        }
    }
}
