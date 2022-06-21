using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class MaxInt
    {
        public void Max(int []arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }

            }
            Console.WriteLine(max);
        }
        static void Main(string[]args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            MaxInt m = new MaxInt();
            m.Max(a);
            
        }
    }
}
