using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class Square
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter no");

            int n = int.Parse(Console.ReadLine());

            int sq = n * n ;

            Console.WriteLine(sq);
        }
    }
}
