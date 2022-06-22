using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject._2darray
{
    class SumColumn
    {
        static void Main(string[]args)
        {
            int[,] a = new int[3, 3];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < a.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum = sum + a[j, i];
                    Console.Write(a[i, j] + " ");
                }
                Console.Write("sum= " + sum);
                Console.WriteLine();
               
            }

        }
    }
}
