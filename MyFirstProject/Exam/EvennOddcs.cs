using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class EvennOddcs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else if (num % 2 != 0)
            {
                Console.WriteLine("odd");
            }
        }
    }
}
