using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAssignmentMedecine
{      enum category
    {
        Orthopologist,cordiologist,ENT
    }
    internal class madicine
    {
        int medicine_id;
        string medicine_name;
        float Price;
        DateTime dOE;
        category ca;

        public madicine()
        {
            medicine_id = 1004;
            medicine_name = "eye drops";
            Price = 128.06f;
            dOE = DateTime.Now;
            ca = 0;
        }

        public madicine(int a, string b, float c, DateTime d,category e)
        {
            medicine_id = a;
            medicine_name = b;
            Price = c;
            dOE = d;
            ca = e;
        }

        public override string ToString()
        {
            return "the medicine id is :" + medicine_id + "\n medicine name :" + medicine_name + "\n Price :" + Price + "\n dOE:" + dOE + "\n category:" + ca;
        }
    }
}
