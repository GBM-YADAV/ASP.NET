using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConsoleHierarchial_inheritance
{
    internal class Student
    {
        public int Rlno { get; set; }
        public string name { get; set; }
        public string Address{ get; set; }

        public Student(int a,string s,string ad)
        {
            Rlno = a;
            name = s;
            Address = ad;
        }
        public void show()
        {
            Console.WriteLine("Details of student : \n Roll No:  " + Rlno + "\nname :" + name + "\n Adreess:" + Address);
        }
        
    }
}
