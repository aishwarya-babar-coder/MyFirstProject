using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject._2darray
{
    /*  
       ***
       * *
       *** 
   */
    class Pattern2
    {
        static void Main(string[]args)
        {
            char[,] a = new char[3, 3];

           
            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    if (i == 0 || j == 0 || i == a.GetUpperBound(0) || j == a.GetUpperBound(1))
                    {
                        a[i, j] = '*' ;
                    }
                    else
                    {
                        a[i, j] = ' ';
                    }
                }
            }

            for(int i=0;i<=a.GetUpperBound(0);i++)
            {
                for(int j=0;j<=a.GetUpperBound(1);j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

}
