using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class pq1
    {
        static void Main(string[]args)
        {
            /*
             1
             10
             101
             1010
             */

            for (int i=1;i<=4;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if(j%2==0)
                    {
                        Console.Write("0");
                       
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
