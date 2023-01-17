using System;
using System.Collections.Generic;
using System.Text;

namespace Console_day4
{
    internal class Product
    {
        int code;
        string name;
        decimal price;
        public Product()
        {
            code = 11;
            name = "new product";
            price = 10.32m;

        }

        public Product(int c,string s,decimal pr)
        {
            code = c;
            name = s;
            price = pr;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
