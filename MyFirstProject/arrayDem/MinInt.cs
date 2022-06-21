using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
   
    class MinInt
    {
        public void Min(int []arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }

            }
            Console.WriteLine(min);
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            MinInt m = new MinInt();
            m.Min(a);

        }
    }
}
