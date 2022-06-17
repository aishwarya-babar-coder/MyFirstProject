using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class CalcChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter a choice");
            Console.WriteLine("+ \n- \n* \n /\n %");
            char choice = Console.ReadLine()[0];

            switch (choice)
            {
                case '+':
                    Console.WriteLine("addition is " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("subtraction is " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("multiplication is " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("division is " + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("remainder is " + (num1 % num2));
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;

            }

        }
    }
}
