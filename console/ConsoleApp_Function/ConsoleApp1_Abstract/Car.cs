using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Abstract
{
    internal class Car:Vehicle
    {       
        public string Brand { get; set; }

        public string model { get; set; }

        public Car(string brand, string model,string color,int speed):base(color,speed)
        {
            Brand = brand;
            this.model = model;
        }

        public override void showSpeed()
        {
            Console.WriteLine(" the speed of the car is :"+speed);
        }
    }
}       
