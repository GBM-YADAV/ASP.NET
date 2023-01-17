using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppDay1Assaignment3
{
    internal class InningsScore
    {

        static public int BallsPlayed;
        static public  int TotalRuns { get; set; }
       static public int[] BallScore = new int[7];

        public InningsScore()
        {
            int BallsPlayed = 30;
            
            float StrikeRate;
            Random rd = new Random();
            for (int i = 0; i < BallsPlayed; i++)
            {
                int ball;
                ball = rd.Next(0, 7);
                if (ball == 5)
                    ball = 0;
                TotalRuns += ball;
                BallScore[ball]++;

            }

        }
        



    }
}
