using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class ArrayReverPrint
    {
        static void Main(string[]args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("original array is ");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }

            Console.WriteLine("reverse array");

            for(int i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
