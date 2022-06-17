using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Calc
    {
        static void Main(string[]args)
        { 
        Console.WriteLine("enter num1");
            int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("enter num2");
            int num2 = int.Parse(Console.ReadLine());

        char ch;
            do
            {
                Console.WriteLine("1.Add \n2.subtract \n3.mult \n4.div \n5.rem");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("addition is " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("subtraction is " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("multiplication is " + (num1* num2));
                        break;
                    case 4:
                        Console.WriteLine("division is " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("remainder is " + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("invalid choice ");
                        break;
                }

    Console.WriteLine("do you want to continue? \npress y OR Y to continue");
                 ch = Console.ReadLine()[0];

            }
while (ch == 'y' || ch == 'Y') ;

        }
    }
}
