using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject._2darray
{
    class PatternN
    {
        static void Main(string[]args)
        {
            int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 3, 5, 7, 1 }, { 2, 1, 6, 8 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == 0 || (i ==j) || j==a.GetUpperBound(1))
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
