using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class SwitchDemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();

            switch (str)
            {
                case "happy":
                    Console.WriteLine("HAPPY");
                    break;
                case "new":
                    Console.WriteLine("NEW");
                    break;
                case "year":
                    Console.WriteLine("YEAR");
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;

            }
        }
    }
}
