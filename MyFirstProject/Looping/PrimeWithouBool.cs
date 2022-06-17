using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class PrimeWithouBool
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for(int i=2;i<=n;i++)
            {
                if(n%2==0)
                {
                    count++;
                }
            }

            if(count==0)
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
