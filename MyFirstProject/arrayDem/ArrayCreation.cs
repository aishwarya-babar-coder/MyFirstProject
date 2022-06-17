using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class ArrayCreation
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4};

            int[] a = new int[4];

            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("display using normal loop");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("display using for each loop");

            foreach (int x in a)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("display using string.join()");

            Console.WriteLine(string.Join(" ", a));
        }
    }
}
