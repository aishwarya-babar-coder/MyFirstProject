using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class Power
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a base");
            int base1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a exponent");
            int expo = int.Parse(Console.ReadLine());

            int mult = 1;
            for(int i=1;i<=expo;i++)
            {
                mult = mult*base1;
            }

            Console.WriteLine("power is "+mult);
            


        }
    }
}
