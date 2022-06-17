using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    
    class StaticOverload
    {
        static void stat()
        {
            Console.WriteLine("area of circle");
        }

        static void stat(int x, int y)
        {
            Console.WriteLine("x = " + x + " y = " + y);
        }

        static void stat(int r)
        {
            Console.WriteLine("value of radius = " + r);
        }

        static void stat(double pi)
        {
            Console.WriteLine("value of pi = " + pi);
        }

        static void Main(string[] args)
        {
            StaticOverload.stat();
            StaticOverload.stat(10, 20);
            StaticOverload.stat(100);
            StaticOverload.stat(3.14);


        }
    }
}
