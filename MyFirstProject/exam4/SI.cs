using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class SI
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter principle");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("enter rate");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("enter period");
            int t = int.Parse(Console.ReadLine());

            int si = p * r * t;

            Console.WriteLine(si);


        }
    }
}
