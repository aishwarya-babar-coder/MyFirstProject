using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject._2darray
{
    class Pattern1
    {
        static void Main(string[]args)
        {
            int[,] a = { {1,2,3,4 },{4,5,6,7 },{1,2,5,6 },{4,4,6,7 } };

            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    if(i==0 || j==0 || i==a.GetUpperBound(0)|| j==a.GetUpperBound(1))
                    {
                        Console.Write(a[i, j]);
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
