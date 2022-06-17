using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Great
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second no");
            int num2 = int.Parse(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("first no is greater "+num1);
            }
            else
            {
                Console.WriteLine("second number is greater "+num2);
            }

        }
    }
}
