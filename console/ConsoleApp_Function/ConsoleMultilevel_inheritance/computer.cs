using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class computer:electric
    {
        string os;
        string brand;

        public computer(string os, string brand, string circut, string integrater) :base(circut,integrater)
        {
            this.os = os;
            this.brand = brand;
        }
        public override string ToString()
        {
            return circut
        }
    }
}
