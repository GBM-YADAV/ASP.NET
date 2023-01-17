using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1_Abstract
{
    internal class Sparrow:Bird
    {
        string type;

        public Sparrow(string type,string color,int weight):base(color,weight)
        {
            this.type = type;
        }

        public override void voice()
        {
            Console.WriteLine("the voice of Sparrow is ----------");
        }
    }
}
