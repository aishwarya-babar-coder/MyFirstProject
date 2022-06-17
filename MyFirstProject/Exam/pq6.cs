using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class pq6
    {
        /*
        1
        AB
        123
        ABCD
         */
        static void Main(string[]args)
        {
            for(int i=1;i<=4;i++)
            {
                char ch = 'A';
                for (int j=1;j<=i;j++)
                {
    
                    if(i%2==0)
                    {
                        Console.Write(ch);
                        ch++;
                    }
                    else
                    {
                        Console.Write(j);
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
