using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Manager:Employee
    {
        int saleQnty;
        int comision;

        public Manager(int sa,int c,string name,double sal):base(name,sal)
        {
            saleQnty = sa;
            comision = c;
        }

        public new void  GrossSal()
        {
            Console.WriteLine("the gross salary is:{0:f2}", basic_sal + 0.2 * basic_sal+(saleQnty*comision));
        }
    }
}
