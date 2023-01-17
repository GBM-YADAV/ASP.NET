using system;
using system.collections.generic;
using console_day5;

namespace consolegeneric
{
    internal class program
    {
        static void main(string[] args)
        {
            list<int> ints = new list<int>();
            ints.add(56);
            ints.add(2);
            ints.add(4);

            ints.add(23);
            ints.add(5);
            ints.sort();

            student[] stu = new student[4];
            stu[0] = new student() { rollno = 844, name = "giri" };
            stu[1] = new student() { rollno = 14, name = "vamsi" };
            stu[2] = new student() { rollno = 73, name = "hari" };
            queue<student> lst = new queue<student>();
            lst.enqueue(new student() { rollno = 52, name = "giri" });
            lst.enqueue(new student() { rollno = 14, name = "vamsi" });
            lst.enqueue(new student() { rollno = 65, name = "hari" });

            lst.enqueue(new student() { rollno = 56, name = "mouni" });

            lst.enqueue(new student() { rollno = 123, name = "hlo" });






            foreach (student i in lst)
            {
                console.writeline(i.rollno + "    " + i.name);
            }

            console.writeline("the sorted list\n");



        }
    }
}
