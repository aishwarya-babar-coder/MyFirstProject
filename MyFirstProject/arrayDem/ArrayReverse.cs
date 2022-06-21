using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class ArrayReverse
    {
        public void reverse(int[]arr)
        {
            int j = arr.Length - 1;
            Console.WriteLine(string.Join(" ", arr));
            for(int i=0;i<arr.Length/2;i++)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
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
            ArrayReverse r = new ArrayReverse();
            r.reverse(a);
        }
    }
}
