using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Abstract
{
    abstract internal class Vehicle
    {
        public string color { get; set; }
        public int speed { get; set; }

        public Vehicle(string color,int speed)
        {
            this.color = color;
            this.speed = speed;
        }

        abstract public void showSpeed();

        public void showColor()
        {
            Console.WriteLine("The the color of the vehicle is :"+color);
        }


    }
}
