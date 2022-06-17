using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class Fibon
    {
        static void Main(string[]args)
        {
            Console.WriteLine("fibonacci series of range 10 is");
            int num1 = 0, num2 = 1, num3;
            Console.Write(num1 + " " + num2 + " ");

            int temp;
            for (int i = 2; i <= 10; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                temp = num1;
                num1 = num2;
                num2 = num3;

            }
        }
    }
}
