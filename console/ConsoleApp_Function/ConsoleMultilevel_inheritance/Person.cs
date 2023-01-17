using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class Person
    {

        string name;
        String address;
        String contact;
        public Person()
        {
            name = "gir";
            address = "chr";
            contact = "223245424";
        }

        public Person(String na, String ad, string co)
        {
            name = na;  
            address = ad; 
            contact = co;
            Console.WriteLine("person  ");
        }

    }
}
