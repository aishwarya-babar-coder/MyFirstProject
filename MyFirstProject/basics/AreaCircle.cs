using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class AreaCircle
    {
        static void Main(string[]args)
        {
            int radius = 5;
            double pi = 3.14, area;
            area = pi * radius * radius;
            Console.WriteLine("area of circle is " + area);
        }
    }
}
