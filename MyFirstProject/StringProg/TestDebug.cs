using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class TestDebug
    {
        static void Main(string[]args)
        {

            Console.WriteLine("enter first no");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second no");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("addition is " + c);
        }
    }
}
