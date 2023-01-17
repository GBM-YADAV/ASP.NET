using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class Cylinder:Circle
    {
        public  int height { get; set; }

        public Cylinder()
        {
            height = 50;
        }
        public Cylinder(int h,int r,int x,int y):base(r,x,y)
        {
            height = h;     
        }
    }
}
