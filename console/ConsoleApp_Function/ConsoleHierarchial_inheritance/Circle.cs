using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Circle:Shape
    {
        public int radius { get; set; }

        public Circle(int r,string color,int side=0):base(side,color)
        {
            radius = r;
        }
        public override void Area()
        {
            Console.WriteLine(" \n\n\tthe area or circle is :{0:f2}",Math.PI*2*radius*radius);
        }

    }
}
