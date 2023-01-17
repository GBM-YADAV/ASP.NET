using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class Point
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        public Point()
        {
            X = 10;
            Y = 20;
        }
        public Point(int a ,int b)
        {
            X = a;
            Y = b;
        }

    }
}
