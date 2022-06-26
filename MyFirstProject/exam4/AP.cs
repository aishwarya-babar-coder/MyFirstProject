using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class AP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length");
            int L = int.Parse(Console.ReadLine());

            Console.WriteLine("enter breadth");
            int B = int.Parse(Console.ReadLine());

            int peri = 2 * (L + B);

            int area = L * B;

            Console.WriteLine("perimeter is " + peri);

            Console.WriteLine("area is " + area);

        }
    }
}
