using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    
   
    
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int X; // Cost of the ticket

            int TP; //No. Of Tickets Purchased
                    //
            float Total=0;
            float TExp=0; //Total Expenses

            X= Convert.ToInt32(Console.ReadLine());

            TP = Convert.ToInt32(Console.ReadLine());

             Total = X * TP; // Cost of the ticket* No. of Tickets Purchased

            if (TP < 50)

            {
                Console.WriteLine("{0:f2}", Total);

            }

            else if (TP >= 50 && TP <= 100)
            {
                 TExp = Total * (10 * Total) / 100; Console.WriteLine("{0:f2}", TExp);
            }
            else if (TP >= 101 && TP <= 200)
            {

                TExp = Total * (20 * Total) / 100;
            }

            else if (TP >=201 && TP <= 490)
            {

                    TExp = Total*(30 * Total) / 100;
                Console.WriteLine("{0:f2}", TExp);

            }
            else if (TP >= 401 && TP <= 500)
            {
                TExp =Total*(40 * Total)/ 100;
                Console.WriteLine("{0:f2}", TExp);
            }
            else
            {
                TExp=Total*( 50*Total)/ 100;
                Console.WriteLine("{0:f2}", TExp);
            }


            Console.WriteLine("{0:f2}", TExp);
        }



    }

}
    



