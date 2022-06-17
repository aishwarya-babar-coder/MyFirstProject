using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class ArraySum
    {
        static void Main(string[]args)
        {
            int[] a = new int[5];

            int sum = 0;
            Console.WriteLine("enter elements");

            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                sum = sum + a[i];
            }
            Console.WriteLine("elements in the array are ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("sum of elements in array is " + sum);


        }
    }

}
