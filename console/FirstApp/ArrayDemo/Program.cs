using System;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[5];
            ar[0] = 10;
            ar[1] = 20;
            ar[2] = 30;
            ar[3] = 40;
            ar[4] = 50;

            for(int i=0;i<ar.Length;i++)
            {
                Console.WriteLine(ar[i]);
            }

            int[] ar2 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.WriteLine(ar2[i]);
            }

            int[] ar3 = { 11, 12, 13, 14, 15 };
            for (int i = 0; i < ar3.Length; i++)
            {
                Console.WriteLine(ar3[i]);
            }

            int[,] mar = new int[3, 4];
            mar[0,0] = 00;
            mar[0,1] = 01;
            mar[0,2] = 02;
            mar[0,3] = 03;

            mar[1,0] = 00;
            mar[1,1] = 01;
            mar[1,2] = 02;
            mar[1,3] = 03;
            
            mar[2,0] = 00;
            mar[2,1] = 01;
            mar[2,2] = 02;
            mar[2,3] = 03;

            for (int i = 0; i < mar.GetLength(0); i++)
            {
                for (int j = 0; j < mar.GetLength(1); j++)
                {
                    Console.Write(mar[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine($"total no of values: {mar.Length}");
            Console.WriteLine($"total no of rows: {mar.GetLength(0)}");
            Console.WriteLine($"total no of columns : {mar.GetLength(1)}");

            //jagged arrays
            int[][] jar = new int[3][];
            jar[0] =new int[] {10,20,30,40,50,60,};
            jar[1] = new int[] { 17, 25, 30 };
            jar[2] = new int[] { 10, 20, 30, 40};

            Console.WriteLine($"the length of jar is : {jar.Length}");
            Console.WriteLine($"the first row length is : {jar[0].Length}");
            Console.WriteLine($"the second row length is : {jar[1].Length}");
            Console.WriteLine($"the third row length is : {jar[2].Length}");

            for (int i = 0; i < jar.Length; i++)
            {
                for (int j = 0; j < jar[i].Length; j++)
                {
                    Console.Write(jar[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
