using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultilevel_inheritance
{
    internal class Pc:computer
    {
        string moniter;
        string keyboard;
        public Pc(string moniter, string keyboard, string os, string brand, string circut, string integrater):base(os, brand, circut, integrater)
        {
            this.moniter = moniter;
            this.keyboard = keyboard;
        }

        public override string ToString()
        {
            return "moniter  :"+ moniter+"keboard used"+keyboard+"operating system"+os+""
        }
    }
}
