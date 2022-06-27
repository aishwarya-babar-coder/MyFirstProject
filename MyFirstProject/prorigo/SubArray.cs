using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.prorigo
{
    class SubArray
    {
        static void Main(string[]args)
        {
            //accept size
            Console.WriteLine("enter size");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("enter elements");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int j;
            int max = 0;
            int zero, ones;

            //find largest subarray length having equal zeros and once

            for(int i=0;i<arr.Length;i++)
            {
                zero = 0;
                ones = 0;
                for(j=i;j<arr.Length;j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if(zero==ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }
                
            }
           // Console.WriteLine(j);
            Console.WriteLine(max);
        }
    }
}
