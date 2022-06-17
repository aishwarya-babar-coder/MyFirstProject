using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class SwapWithouThird
    {
        static void Main(string[]args)
        {
            int a = 10, b = 20;
            Console.WriteLine("before swapping " + a + " " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swapping " + a + " " + b);

        }
    }
}
