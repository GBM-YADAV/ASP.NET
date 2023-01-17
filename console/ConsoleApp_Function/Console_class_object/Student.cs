//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Console_class_object
//{
    
    
//        enum dept
//        {
//            it, Account, civil, sale, Hr, electrical
//        }
//        internal class Student
//        {
//            int sid;
//            string Firstname;
//            string lastname;
//            dept designation;
//            double marks;
//            DateTime DOJ;
//            static int count = 0;


//            // public Employee( int a, string b,string c, string d, double e,Date )
//            public Student()
//            {

//                sid = 1;
//                Firstname = "giri";
//                lastname = "babu";
//                designation = dept.sale;
//                marks = 3000.66;
//                DOJ = DateTime.Now;
//                count++;
//            }
//            public Employee(int a, string b, string c, dept d, Double e, DateTime f)
//            {

//                eid = a;
//                Firstname = b;
//                lastname = c;
//                designation = d;
//                salary = e;
//                DOJ = f;
//                count++;

//            }
//            public override string ToString()
//            {
//                return "employee details are : \n empid: " + eid + "\n firstname:" + Firstname + "\n last name:" + lastname + "\ndesignatiom: " + designation + "\nsalary: " + salary + "\n DOJ: " + DOJ;
//            }

//            public static void showcount()
//            {
//                Console.WriteLine("the total number of employees are :" + count);
//            }

//        }
//}
