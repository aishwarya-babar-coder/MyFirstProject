using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class Twin
    {
        static bool Prime(int n1)
        {
            bool isprime = true;

            for (int i = 2; i <= n1 / 2; i++)
            {
                if (n1 % i == 0)
                {
                    isprime = false;
                }
            }

            if (isprime == true)
            {
                //Console.WriteLine("prime");
                return true;
            }
            else
            {
                //Console.WriteLine("not prime");
                return false;
            }
            return false;

        }
        static void Main(string[]args)
        {
            Console.WriteLine("enter first no");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter sec no");
            int n2 = int.Parse(Console.ReadLine());

            
            if(Twin.Prime(n1) && Twin.Prime(n2)==true && Math.Abs( n1-n2)==2)
            {
                Console.WriteLine("twin");
            }
            else
            {
                Console.WriteLine("no");
            }             

        }
    }
}
