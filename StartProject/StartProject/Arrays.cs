using System;
using System.Collections.Generic;
using System.Text;

namespace Idea1
{
    internal class Arrays
    {
        const int SIZE = 11;
        public static void TestArrays()
        {
            int[] scores = new int[SIZE];
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write("Score: ");
                scores[i] = MethodLibraries.ReadInt("", 0, 1000);
            }
            foreach (int i in scores)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n " + string.Join(" ", scores));
        }
        public static void TwoDArray()
        {
            int[,] board = new int[3, 3];
            board[0,0] = 3; board[1,1] = 1; board[2,2] = 2;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
         public static readonly string[] MONTHS =
[
                null,
                "January", "February",
                "March", "April", "May",
                "June", "July", "August",
                "September", "October", "November", "December"
];
        public static void NumberOfMonth(int number)
        {
            if (number >= 1 && number <= 12)
            {
                Console.WriteLine(MONTHS[number]);
            }
            else
            {
                Console.WriteLine("Invalid month number.");
            }
        }
    }
}