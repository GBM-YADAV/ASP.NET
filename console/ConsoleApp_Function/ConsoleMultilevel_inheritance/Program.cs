using System;

namespace ConsoleMultilevel_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pc p = new Pc("18 inch moniter", "black keyboard", "linx", "hp", "integrated circut", "xyz");
            Console.WriteLine(p);
            //Student p = new Student(101, 98, 11, "giri", "chitoor", "94837546545");
            ////Point P = new Point();
            //Student.s

            ////Circle c1 = new Circle(5,0, 2);

            ////Console.WriteLine("circle detais are :\nRadius :"+c1.radius+"\n cordinates:"+c1.X+","+c1.Y);
            ////Cylinder cy = new Cylinder();
            ////Cylinder cy2 = new Cylinder(23, 5, 2, 6);
            ////Console.WriteLine(" the cylinder details are :\n Height :" + cy.height + "\nRadius: " + cy.radius + "\n cordinates: " + cy.X + ", " + cy.Y);
            ////Console.WriteLine(" the cylinder details are :\n Height :" + cy2.height + "\nRadius: " + cy2.radius + "\n cordinates: " + cy2.X + ", " + cy2.Y);
        }
    }
}
