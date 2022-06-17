using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class AgeWt
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("enter weight");
            int wt = int.Parse(Console.ReadLine());

            if(age>18)
            {
                if(wt>50)
                {
                    Console.WriteLine("elligible for blood donation");
                }
                else
                {
                    Console.WriteLine("not elligible for blood donation");
                }
            }
            else
            {
                Console.WriteLine("not elligible for blood donation");
            }
        }
    }
}
