using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class Table
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("table of " + n);

            int mult;
            for(int i=1;i<=10;i++)
            {
                mult = i * n;
                Console.WriteLine(mult);
            }
        }
    }
}
