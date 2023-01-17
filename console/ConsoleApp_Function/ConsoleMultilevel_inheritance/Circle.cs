using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class Circle:Point
    {
        protected int radius { get; set; }

        public Circle()
        {
            radius = 20;
        }
        public Circle(int r,int x,int y):base(x,y)
        {
            radius = r;
        }
    }
}
