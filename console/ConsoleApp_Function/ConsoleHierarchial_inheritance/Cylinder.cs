using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Cylinder:Circle
    {
        public int height { get; set; }

        public Cylinder(int h, int r, string color, int side = 2):base(r,color,side)
        {
            height = h;
        }
        //Shadowing effect
        public  new void Area()
        {
            double A = 2 * Math.PI * radius * (radius + height);
            Console.WriteLine("Surafce area of cylinder is:{0:f2}" , A);
        }
        
    }
}
