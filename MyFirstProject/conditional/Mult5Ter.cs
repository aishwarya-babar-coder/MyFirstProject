using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Mult5Ter
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            string mult = num % 5 == 0 ? "number is multiple of 5" : "number is not multiple of 5";

            Console.WriteLine(mult);
        }
    }
}
