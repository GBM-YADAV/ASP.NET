using System;
using System.Runtime.InteropServices;

namespace ConsoleApp_struc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(10, 20);
            Console.WriteLine("x co ordinate:"+p.X);
        }
    }
    
    public struct Point
    {
        int x, y;
        public Point(int a, int y)
        {
           x = a;
            this.y = y;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
    }


}
