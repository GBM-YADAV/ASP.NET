using System;
using System.Collections.Generic;
using System.Text;

namespace Console_lamdaa
{
    internal class student
    {
        public int id { get; set; }
        public string  name { get; set; }

        public string Gender{ get; set; }

        public string branch { get; set; }

        public static List<student> GetStudent()
        {
            List<student> stu = new List<student>()
            {
                new student(){id=1001,name="seeta",Gender="female",branch="civil"},
                new student(){id=1003,name="shiva",Gender="male",branch="biotec"},
                new student(){id=1003,name="harish",Gender="male",branch="civil"},
                new student(){id=1004,name="ram",Gender="male",branch="com"},
            };

            return stu;
        }
    }
   
}
