using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class PeriRect
    {
        static void Main(string[]args)
        {
            int length = 5, breadth = 8, perimeter;
            perimeter = 2 * (length + breadth);
            Console.WriteLine("perimeter of a rectangle is " + perimeter);
        }
    }
}
