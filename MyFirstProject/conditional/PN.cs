using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class PN
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("number is positive");
            }
            else if(num<0)
            {
                Console.WriteLine("number is negative");
            }
        }
    }
}
