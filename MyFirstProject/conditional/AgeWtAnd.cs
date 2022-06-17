using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class AgeWtAnd
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter weight");
            int wt = int.Parse(Console.ReadLine());

            if(age>18 && wt>50)
            {
                Console.WriteLine("elligible");
            }
            else
            {
                Console.WriteLine("not elligible");
            }
        }
    }
}
