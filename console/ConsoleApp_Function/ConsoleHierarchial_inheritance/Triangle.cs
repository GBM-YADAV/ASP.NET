using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Triangle:Shape
    {
        public int side1 { get; set; }
        public int side2 { get; set; }

        public int side3 { get; set; }

        public Triangle(int s1, int s2,int s3,string color, int sides = 3):base(sides, color)
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
        }
        public override void Area()
        {
            int s = (side1 + side2 + side3)/2;
            Console.WriteLine("\n \n \tArea of Triangle is :{0:f2}" + Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3)));

        }
    }
}
