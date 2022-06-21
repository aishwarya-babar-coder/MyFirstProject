using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class SumPrime
    {
        public void primesum(int []arr)
        {
            int sum = 0;
            Console.WriteLine("prime nos are ");
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
                    Console.WriteLine(arr[i]);
                    sum = sum + n;
                }
            }
            Console.WriteLine("sum of prime nos are "+sum);
        }
        static void Main(string[]args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            SumPrime s1 = new SumPrime();
            s1.primesum(a);
          }
    }

}
