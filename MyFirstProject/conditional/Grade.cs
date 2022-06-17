using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Grade
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter marks of 1st subhects out of 100");
            double m1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of 2nd subhects out of 100");
            double m2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of 3rd subhects out of 100");
            double m3 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of 4th subhects out of 100");
            double m4 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter marks of 5th subhects out of 100");
            double m5 = double.Parse(Console.ReadLine());

            double perc = ((m1+m2+m3+m4+m5)/ 500) * 100;

            Console.WriteLine("percentage is " + perc);

            if(perc>=70)
            {
                Console.WriteLine("distinction");
            }
            else if(perc>=60 && perc<70)
            {
                Console.WriteLine("first class");
            }
            else if(perc>=40 && perc<60)
            {
                Console.WriteLine("second class");
            }
            else if(perc<40)
            {
                Console.WriteLine("fail");
            }

        }
    }
}
