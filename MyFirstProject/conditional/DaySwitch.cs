using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class DaySwitch
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number between 1 to 7 to check day name");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7: Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;
            }
        }
    }
}
