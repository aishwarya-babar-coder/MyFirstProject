using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class PrintPrime
    {
        public void isprime(int[]arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isprime = true;
                int n = arr[i];
                for (int j = 2; j < n; j++)
                {
                    if (n % j == 0)
                    {
                        isprime = false;
                        break;
                    }

                }
                if (isprime == true)
                {
                    Console.WriteLine(arr[i] + "prime");
                }
                else
                {
                    Console.WriteLine(arr[i] + "no prime");
                }
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter array elements");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            PrintPrime p = new PrintPrime();
            p.isprime(a);
        }
    }
}
