using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class DB
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            string b = " ";
            while(num>0)
            {
                int rem = num % 2;

                b = rem+b;

                num = num / 2;
            }

            Console.WriteLine(b);
        }
    }
}
