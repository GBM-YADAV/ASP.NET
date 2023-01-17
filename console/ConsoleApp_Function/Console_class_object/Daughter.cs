using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Console_class_object
{
    internal class Daughter:Mother
    {
        String Dname;
        int D_age;

        public Daughter()
        {
            Dname = "seeta";
            D_age = 20;
            Console.WriteLine("its the Daughter constructor");
        }

        public Daughter(string a, int b,string c,int d):base(c,d)
        {
            Dname = a;
            D_age = b;
            Console.WriteLine("its the Daughter constructor");
        }
        public override string ToString()
        {
            return "daughter name :"+Dname+"\n Age  :-  "+D_age+" "+base.ToString();
        }
    }
}
