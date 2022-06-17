using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Calculator
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a choice");
            Console.WriteLine("1.addition \n2subtraction\n3.multiplication\n4.division\n5.remainder");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1: Console.WriteLine("addition is " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("subtraction is " + (num1 - num2));
                    break;
                case 3:Console.WriteLine("multiplication is " + (num1 * num2));
                    break;
                case 4: Console.WriteLine("division is " + (num1 / num2));
                    break;
                case 5:Console.WriteLine("remainder is " + (num1 % num2));
                    break;
                default: Console.WriteLine("invalid choice");
                    break;

            }

        }
    }
}
