

using System;

namespace ConsoleHierarchial_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle R = new Rectangle(120, 110, "red");
            //R.Area();
            //Triangle T = new Triangle(20, 30, 40, "yellow");
            //T.Area();
            //Circle c = new Circle(30, "green");
            //c.Area();
            //Cylinder cy = new Cylinder(29, 30, "blue", 3);
            //cy.Area();

            //Circle C = cy;
            //C.Area();

            //Employee emp = new Employee("giri", 20000.34);
            //emp.GrossSal();
            //Manager M = new Manager(200, 50, "kika", 20000.34);
            //M.GrossSal();
            //Employee E = M;
            //E.GrossSal();

            StuAcResult s = new StuAcResult(45, 67, 87, 101, "giri", "Chittoor");
            s.show();
            SportResult s1 = new SportResult("handball", "A+", 101, "giri", "Chittoor");
            s1.show();
        }
    }
}
