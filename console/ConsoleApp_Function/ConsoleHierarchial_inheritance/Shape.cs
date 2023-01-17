using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Shape
    {
        public int Sides { get; set; }
        public string Color { get; set; }



        public virtual void Area()
        {
            Console.WriteLine("Formula for specific shape ");
        }



        public Shape(int s, string color)
        {
            Sides = s;
            Color = color;
        }



    }
}
