using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Interface
{
    internal class Car : Iprintable
    {
        public String model { get; set; }

        public String brand { get; set; }
        public int Man_year { get; set; }

        public void print()
        {
            Console.WriteLine("brand:" + brand + "model:" + model );
        }

        public void showDate()
        {
            int dt = DateTime.Now.Year;
            Console.WriteLine("\n manufacture year"+Man_year);
        }
    }
}
