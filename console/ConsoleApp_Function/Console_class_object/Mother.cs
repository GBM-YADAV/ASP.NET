using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Console_class_object
{
    internal class Mother
    {
        string Mname;
        int M_age;


        public Mother()
        {
            Mname = "Chinnapapa";
            M_age = 45;

            Console.WriteLine("its the mother constructor");
        }
        public Mother(string a,int b)
        {
            Mname = a;
            M_age = b;
            Console.WriteLine("its the mother constructor");
        }
        public override string ToString()
        {
            return "\n mother name :" + Mname + "\n Age  :-  " + M_age;
        }

    }
}
