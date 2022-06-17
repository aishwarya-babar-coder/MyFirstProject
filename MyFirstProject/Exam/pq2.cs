using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class pq2
    {
        static void Main(string[]args)
        {
            /*
             1
             23
             456
             */
            int k = 1;
            for(int i=1;i<=3;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(k);
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
