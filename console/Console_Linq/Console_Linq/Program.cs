using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Console_Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 34, 54, 67, 8, 45};
            List<String> arrayList = new List<string>();
            arrayList.Add("Giri");
            arrayList.Add("vamsi");
            arrayList.Add("mohana");
            arrayList.Add("cherry");
            arrayList.Add("dharshan");
            arrayList.Add("deepthi");

            // syntax // var result = from variable in datasource select variable;


            var result = from n in 
                         numbers where  n%5==0
                         select n;

            foreach(int i in result )
            {
                Console.WriteLine(i);
            }

            var nam =from na in arrayList
                     where na=="Giri"  
                     select na;

            foreach (string i in nam)
            {
                Console.WriteLine(i);
            }

            // lamda expresion
            var r = arrayList.Any(na => na.Contains("Gi"));

            Console.WriteLine(r);


            var ad = arrayList.All(na => na.Contains(""));
            Console.WriteLine(ad);

            float []temp= { 12,45,67.4f,22,89.3f };

            var ans1 = temp.Average();

            Console.WriteLine("avg temperature is"+temp.Average());
            Console.WriteLine("avg temperature is" + temp.Sum());
            Console.WriteLine("avg temperature is" + temp.Max());
            Console.WriteLine("avg temperature is" + temp.Min());

        }

    }
}
