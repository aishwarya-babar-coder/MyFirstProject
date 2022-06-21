using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class SepZero
    {
        public void sep(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {   
                    if (arr[i] == 0)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                }
            }

            Console.WriteLine("new array is ");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            SepZero s1 = new SepZero();
            s1.sep(a);
        }
    }
}
