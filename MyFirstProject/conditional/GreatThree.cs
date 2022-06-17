using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class GreatThree
    {
        static void Main(string[]args)
        {
            Console.WriteLine("write first no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("write second no");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("write three no");
            int num3 = int.Parse(Console.ReadLine());

            if(num1 >num2 && num1>num3)
            {
                Console.WriteLine("first no is greater");
            }
            else if(num2>num1 && num2>num3)
            {
                Console.WriteLine("second no is greater");
            }
            else
            {
                Console.WriteLine("third no is greater");
            }
        }

    }
}
