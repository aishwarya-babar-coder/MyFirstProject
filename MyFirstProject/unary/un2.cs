using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.unary
{
    class un2
    {
        static void Main(string[] args)
        {
            int a = 2, b = 2;

            int x = ++a + ++b + a;

            Console.WriteLine(x + " " + a + " " + b);

            x = --a + b++;

            Console.WriteLine(x + " " + a + " " + b);

            x = a-- - --b -a;

            Console.WriteLine(x + " " + a + " " + b);

            x = ++a + --b + b++;

            Console.WriteLine(x + " " + a + " " + b);
        }


    }
}
