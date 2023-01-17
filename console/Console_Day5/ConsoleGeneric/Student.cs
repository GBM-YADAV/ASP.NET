using System;
using System.Collections.Generic;
using System.Text;

namespace Console_Day5
{
    internal class Student:IComparable
    {
        public int rollno { get; set; }
        public string name { get; set; }

        //public int CompareTo(object obj)
        //{

        //    Student stud= (Student)obj;
        //    if (this.rollno < stud.rollno)
        //        return -1;
        //    else if (this.rollno > stud.rollno)
        //        return 1;
        //    else
        //        return 0;   
        //}

        public int CompareTo(object obj)
        {
            Student stud = (Student)obj;
            return String.Compare(this.name, stud.name);
        }

        public override string ToString()
        {
            return rollno+"  "+name ;
        }
    }
}
