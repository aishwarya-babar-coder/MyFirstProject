using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class TableTo5
    {
        static void Main(string[]arg)
        {

            int n=1;
            while(n<=5)
            {
                int mult;
                Console.WriteLine("table of " + n);
                for (int i = 1; i <= 10; i++)
                {
                    mult = i * n;
                    Console.WriteLine(mult);
                }
                n++;
                Console.WriteLine("-----------------------------");
            }
        }
    }
}
