using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Spy
    {
        static void Main(string[]args)
        {
            //sum of digit==product of digit

            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int prod = 1;

            while(n>0)
            {
                int rem = n % 10;
                sum = sum + rem;
                prod = prod * rem;
                n = n / 10;
            }
            Console.WriteLine(sum + "   " + prod);
            if(sum==prod)
            {
                Console.WriteLine("spy");
            }
            else
            {
                Console.WriteLine("not spy");
            }

        }
    }
}
