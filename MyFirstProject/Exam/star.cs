using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class star
    {
        static void Main(string[] args)
        {
            int rows = 8;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= rows -i; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
