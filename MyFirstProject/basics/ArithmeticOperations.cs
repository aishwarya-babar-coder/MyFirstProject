using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class ArithmeticOperations
    {
        static void Main(string[]args)
        {
            int a = 100, b = 10, add, sub, mult, div, rem;
            add = a + b;
            sub = a - b;
            mult = a * b;
            div = a / b;
            rem = a % b;

            Console.WriteLine("additions is " + add + "\nsubtraction is " + sub + "\nmultiplication is " + mult + "\ndivision is " + div + "\nremainder is " + rem);



        }
    }
}
