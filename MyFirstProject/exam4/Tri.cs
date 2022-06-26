using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class Tri
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter base");
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("enter height");
            int H = int.Parse(Console.ReadLine());

            double area = 0.5 * B * H;

            Console.WriteLine("area is " +area);
        }
    }
}
