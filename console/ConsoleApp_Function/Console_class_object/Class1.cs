using System;
using System.Collections.Generic;
using System.Text;

namespace Console_class_object
{
    internal class Class1
    {

        private int eng,mat,com;

       
        public Class1(int a, int b, int c)
        {
            eng = a;
            mat = b;
            com = c;
        }


        public override string ToString()
        {
            return " eng: "+eng+ "\nmat: " + mat + "\n com: " + com;
        }
    }
}
