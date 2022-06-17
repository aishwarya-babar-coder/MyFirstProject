using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Mult5
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num%5==0)
            {
                Console.WriteLine("number is multiple of 5");
            }
            else
            {
                Console.WriteLine("number is not multiple of 5");
            }
        }
    }
}
