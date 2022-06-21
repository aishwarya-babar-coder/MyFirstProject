using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class PerfectSquare
    { 
        public void perfect(int[]arr) //23,43,25,49,12,9,78,66,39,0
        {
            Console.WriteLine("perfect square nos are ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 2; k < arr[i] ; k++)
                {
                    if (arr[i] == k*k)  
                    {
                        Console.WriteLine(arr[i]);
                        break;
                    }
                }
            }
        }
        static void Main(string[]args)
        {
            int[] a = new int[8];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            PerfectSquare p1 = new PerfectSquare();
            p1.perfect(a);
        }
    }
}
