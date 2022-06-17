using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class SwapWithThird
    {
        static void Main(string[]args)
        {
            int a=10, b=20, temp;
            Console.WriteLine("before swapping " + a + " " + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping " + a + " " + b);
        }
    }
}
