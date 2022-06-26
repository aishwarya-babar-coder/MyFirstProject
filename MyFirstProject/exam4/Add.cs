using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class Add
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter no1");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter no2");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine(c);
        }
    }
}
