using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_lamdaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> mstu = new List<student>()
            {
                new student(){id=1006,name="sathish",Gender="female",branch="civil"},
                new student(){id=1006,name="arun",Gender="male",branch="biotec"},

            };
            var S = from s in student.GetStudent()
                    where s.Gender == "male"
                    select s;



            //var result = from stu in mstu
            //             where stu.branch=="biotec"
            //             select stu;
            int a = S.Count();

            foreach (student s in S)
            {
                Console.WriteLine(s.name + " " + s.id);
            }
            Console.WriteLine(a);


            //============================

            // lamda expression

            //var result = student.GetStudent().ToList(); 

            //foreach(student stud in result)
            //{
            //    Console.WriteLine(stud.name+" "+stud.branch);
            //}

            //where cluase can be replaced by lamda expression as folows
            //

            //var r1 = student.GetStudent().Where(s => s.id <= 1003);


            //foreach(student sttu in r1)
            //{
            //    Console.WriteLine(sttu.id+" "+sttu.name);
            //}


            //var r2 = student.GetStudent().SingleOrDefault(s => s.name == "shiva");
            //Console.WriteLine(r2.name+"  "+r2.Gender);

            //var r4 = student.GetStudent().Single(s => s.name == "seeta");
            //Console.WriteLine(r4.name + "  " + r4.Gender);


            //var r3 = student.GetStudent().FirstOrDefault(s => s.name == "shiva");
            //Console.WriteLine(r3.name + "  " + r3.Gender);

            //    int N = student.GetStudent().FindIndex(s => s.name == "ram");
            //    Console.WriteLine("position of ram is"+N);

            //    List<student> stlist = student.GetStudent();

            //    stlist.RemoveAt(3);

            //    foreach (student st in stlist)
            //        Console.WriteLine(st.name);


            var Pr = Student1.GetStudents().SelectMany(s => s.Programming).Distinct();

            foreach (string p in Pr)
            {
                Console.WriteLine(p);
            }

        }
    }
}
