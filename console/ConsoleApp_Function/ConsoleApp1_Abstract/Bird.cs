using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Abstract
{
    abstract internal class Bird
    {
        public string color { get; set; }

        public int weight { get; set; }

        public Bird(string color, int weight)
        {
            this.color = color;
            this.weight = weight;
        }

        public abstract void voice();

        public void showcolor()
        {
            Console.WriteLine("color of the bird is "+color);
        }
    }
}
