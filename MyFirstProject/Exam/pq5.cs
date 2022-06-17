using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class pq5
    {
        /*
         1234
         123
         12
         1
         */
        static void Main(string[]args)
        {
            
            for(int i=1;i<=4;i++)
            {
                int c = 1;
                for (int j=4;j>=i;j--)
                {
                    Console.Write(c);
                    c++;
                }
                Console.WriteLine();
            }
        }
    }
}
