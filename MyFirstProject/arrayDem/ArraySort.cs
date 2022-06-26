using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class ArraySort
    {
        public void sort(int[]arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]>arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
        static void Main(string[]args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            ArraySort a1 = new ArraySort();
            a1.sort(a);
        }
    }
}
