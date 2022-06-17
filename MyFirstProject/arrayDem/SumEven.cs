using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class SumEven
    {
        static void Main(string[]args)
        {
            int[] a = new int[5];
            int sum = 0;
            Console.WriteLine("enter elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if(a[i]%2==0)
                {
                    sum = sum + a[i];
                }
            }

            Console.WriteLine("elements in the array are ");
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("sum of even elements in array is "+sum);

        }
    }
}
