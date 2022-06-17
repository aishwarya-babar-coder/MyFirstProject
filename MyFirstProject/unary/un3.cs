using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.unary
{
    class un3
    {
        static void Main(string[]args)
        {
            int a = 2, b = 2, c = 2;

            int x = ++a + b++ + c--;

            Console.WriteLine(x + " " + a + " " + b+" "+c);

            x = --b - ++a - ++c;

            Console.WriteLine(x + " " + a + " " + b + " " + c);

            x = a-- + b++ - c++ - a;

            Console.WriteLine(x + " " + a + " " + b + " " + c);

        }
    }
}
