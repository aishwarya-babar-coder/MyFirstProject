using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class Cube
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no");

            int n = int.Parse(Console.ReadLine());

            int c = n * n * n;

            Console.WriteLine(c);
        }
    }
}
