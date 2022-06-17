using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class LeapYear
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a year");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year%100!=0) || (year%400==0))
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("not leap year");
            }
        
        
        }
    }
}
