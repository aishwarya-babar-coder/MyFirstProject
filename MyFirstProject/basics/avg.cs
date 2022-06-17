using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class avg
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter marks of 5 subject one by one");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            double total = a + b + c + d + e;
            double avg = total / 5;
            double perc = (total / 500) * 100;
            Console.WriteLine("total marks of 5 subjects is " + total);
            Console.WriteLine("percentage of 5 subjects marks is " + perc);
            Console.WriteLine("avg of 5 subjects marks is " + avg);

        }
    }
}
