using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class BD
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int power = 1;
            int sum = 0;
            int p = 0;
            int mult = 1;
            while(num>0)
            {
                int rem = num % 10; ;

                power = (int)(Math.Pow(2, p));

                mult =  power*rem;

                sum = sum + mult;

                p++;

                num = num / 10;
            }

            Console.WriteLine(sum);
        }
    }
}
