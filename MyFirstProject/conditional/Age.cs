using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Age
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            if(age>=13)
            {
                if (age <= 19)
                {
                    Console.WriteLine("teenager");
                }
                else
                {
                    Console.WriteLine("not a teenager");
                }
            }
            else
            {
                Console.WriteLine("no teenager");    
            }
        }
    }
}
