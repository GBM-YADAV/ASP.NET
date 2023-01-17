using System;

namespace ConsoleAppDay1Assaignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            InningsScore match1=new InningsScore();
            InningsScore match2 = new InningsScore();
            InningsScore match3 = new InningsScore();
            InningsScore match4 = new InningsScore();
            InningsScore match5 = new InningsScore();
            float StrikeRate = 100*(float)InningsScore.TotalRuns / 150.00f;
            float AverageRuns = (float)InningsScore.TotalRuns / 5;
            Console.WriteLine("Average Runs of 5 matches      :{0:f2}", AverageRuns);
            Console.WriteLine("Total Runs Scored in 5 matches  :" + InningsScore.TotalRuns);
            for (int i = 0; i < 7; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                    
                Console.WriteLine("Number Of {0}s  in 5 matches    :{1}", i,InningsScore.BallScore[i]);
            }
            Console.WriteLine("Strike Rate of 5 matches      :{0:f2}", StrikeRate);



        }
    }
}
