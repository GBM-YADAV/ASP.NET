using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    enum sporttype { invationGame, NetGame, FiledGame }
    internal class SportResult:Student
    {
        public string SpoName { get; set; }
        public string grade { get; set; }

    
    public SportResult(string sn,string gr, int a, string s, string ad):base(a,s,ad)
    {
            SpoName = sn;
            grade = gr;

    }

        public new void show()
        {
            if(grade=="A+")
            {
                Console.WriteLine("sports performance is : Excelent");
            }
            else if(grade=="A")
            {
                Console.WriteLine("sports performance is : Good");
            }
            else
            {
                Console.WriteLine("sports performance is :need to improve");
            }
        }


   
    }

}
