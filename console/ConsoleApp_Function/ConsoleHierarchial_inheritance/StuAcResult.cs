using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class StuAcResult:Student
    {
        public int  physics { get; set; }
        public int chemistry { get; set; }
        public int math { get; set; }

        public StuAcResult(int phy,int che,int mat, int a, string s, string ad):base(a,s,ad)
        {
            physics = phy;
            chemistry = che;
            math = mat;


        }

        public new void show()
        {
            Console.WriteLine("\t\t\tResults\n\n \tRoll No:" + Rlno + "\n\nname :" + name +"\n\n\tphysics \tchemistry \tmaths\n\t"+physics+"\t "+chemistry+"\t "+math);
            if(physics>=35&&chemistry>=35&&math>=35)
            {
                Console.WriteLine("\n\n\t\tResult: PASS");
            }
            else
            {
                Console.WriteLine("\n\n\t\tResult: FAIL");
            }
        }
    }
}
