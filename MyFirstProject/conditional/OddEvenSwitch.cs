using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class OddEvenSwitch
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int check = num % 2;
            switch(check)
            {
                case 0:
                    Console.WriteLine("even");
                    break;
                case 1:
                    Console.WriteLine("odd");
                    break;
            }
        }
    }
}
