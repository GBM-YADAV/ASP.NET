using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Rectangle:Shape
    {
        public int length { get; set; }
        public int breadth { get; set; }

        public Rectangle(int l,int b,string color,int sides=2):base(sides,color)
        {
            length = l;
            breadth = b;

        }
        public override void Area()
        {
            Console.WriteLine("\n\tArea of Rectagle is :{0:f2} "+(length*breadth));
        }
    }
}
