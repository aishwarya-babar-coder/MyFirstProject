using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class DivTen
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num%10==0)
            {
                Console.WriteLine("divisible by 10");
            }
            else if(num%10!=0)
            {
                Console.WriteLine("not divisible by 10");
            }

        }
    }
}
