using System;

namespace ConsoleAppDay1Assaignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Random rd=new Random();
            int BallsPlayed = 30;
            int TotalRuns=0;
            int[] BallScore=new int[7];
            float StrikeRate;

            for (int i = 0; i < BallsPlayed; i++)
            {
                int ball;
                ball=rd.Next(0,6);
                TotalRuns += ball;
                BallScore[ball]++;

            }
            StrikeRate = TotalRuns / 30.0f;
            Console.WriteLine("Total Runs Scored :"+TotalRuns);
            for(int i=0; i <7; i++)
            {
                Console.WriteLine("Number Of {0}s      :{1}", i, BallScore[i]);
            }
            Console.WriteLine("Strike Rate       :{0:f2}",StrikeRate);


 
        }
    }
}
