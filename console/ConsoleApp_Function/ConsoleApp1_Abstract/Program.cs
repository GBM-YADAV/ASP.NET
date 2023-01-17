using System;

namespace ConsoleApp1_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car C1 = new Car("Maryti", "alto", "red", 300);
            C1.showSpeed();
            //  Vehicle v1=new Vehicle();    the abstract class cannot have an object created in the main

            C1.showColor();
        }
    }
}
