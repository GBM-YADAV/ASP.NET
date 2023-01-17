using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ConsoleAssignmentProduct
{
    enum category
    {
        a,b,c,d,e
        
    }
    internal class Product
    {
        int Product_id;
        string Product_name;
        float Price;
        DateTime dOM;
        category ca; 


        public Product()
        {
            Product_id = 1001;
            Product_name = "laptop";
            Price = 1000.45f;
            dOM = DateTime.Now;
            ca = category.d;
        }

        public Product(int p,string q,float r,DateTime s,category t)
        {
            Product_id = p;
            Product_name = q;
            Price = r;
            dOM = s;
            ca =t;

        }

        public override string ToString()
        {
            return "the Product id is :" + Product_id + "\n Product name :" + Product_name + "\n Price :" + Price + "\n dOM:" + dOM + "\n category:" + ca;
        }


    }
}
