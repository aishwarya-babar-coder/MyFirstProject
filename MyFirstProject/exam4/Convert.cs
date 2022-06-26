using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class Convert
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter length in cm");

            double cm = double.Parse(Console.ReadLine());

            double m = 0.01 * cm;

            Console.WriteLine("meter is " + m);

            double km = 0.001 * m;

            Console.WriteLine("km is " + km);
        }
    }
}
