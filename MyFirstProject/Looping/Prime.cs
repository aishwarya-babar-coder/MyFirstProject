using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class Prime
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            bool isPrime = true;
            for(int i=2; i<n; i++)
            {
                if(n % i == 0)
                {
                    isPrime = false;
                }
            }

            if(isPrime==true)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }
        }
    }
}
