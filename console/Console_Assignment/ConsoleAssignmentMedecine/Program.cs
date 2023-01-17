using System;

namespace ConsoleAssignmentMedecine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            madicine m1 = new madicine();
            madicine m2 = new madicine(1002, "dolo ", 100.23f, d, category.Orthopologist);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
        }
    }
}
