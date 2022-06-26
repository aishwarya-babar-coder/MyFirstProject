using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class ReplaceNeg
    {
        static void Main(string[]args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if(a[j]<0)
                    {
                        a[j] = a[j - 1];
                        a[j] = a[j] * a[j];
                    }
                }
            }

            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i] + "  ");
            }
        }
    }
}
