using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class AreaEquilat
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a side");
            int side = int.Parse(Console.ReadLine());
            double area = (Math.Sqrt(3) * (side * side)) / 4;
            Console.WriteLine("area of equilateral triangle is "+area);

        }
    }
}
