using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject._2darray
{
    class Demo
    {
        static void Main(string[]args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4,5,6}, {7,8,9 } };

            int[,] a = new int[,] { {1,2,3}, {4,5,6}, {7,8,9} };

            int[,] b = new int[3, 3];
            Console.WriteLine("enter elements");
            for(int i=0;i<b.GetLength(0);i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
