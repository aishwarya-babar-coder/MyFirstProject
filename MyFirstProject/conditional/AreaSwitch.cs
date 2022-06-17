using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class AreaSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a choice to calculate: ");
            Console.WriteLine("c for area of circle \nr for area of rectangle \nt for area of triangle \ns for area of square");
            char ch = Console.ReadLine()[0];

            switch (ch)
            {
                case 'c':
                    Console.WriteLine("enter radius");
                    int radius = int.Parse(Console.ReadLine());
                    double pi = 3.14;
                    double circle = pi * radius * radius;
                    Console.WriteLine("area of circle is "+circle);
                    break;
                case 'r':
                    Console.WriteLine("enter length");
                    int length = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter breadth");
                    int breadth = int.Parse(Console.ReadLine());
                    int rect = length * breadth;
                    Console.WriteLine("area of rectangle is "+rect);
                    break;
                case 't':
                    Console.WriteLine("enter base");
                    int bas = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter height");
                    int height = int.Parse(Console.ReadLine());
                    double tri = 0.5 * bas * height;
                    Console.WriteLine("area of triangle is "+tri);
                    break;
                case 's':
                    Console.WriteLine("enter side");
                    int side = int.Parse(Console.ReadLine());
                    int squ = side * side;
                    Console.WriteLine("area of square is "+squ);
                    break;
                default:
                    Console.WriteLine("INVALID CHOICE");
                    break;
            }
        }
    }
}
