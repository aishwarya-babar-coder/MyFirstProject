using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class OddEvenTer
    {
 
       static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            string result=num % 2 == 0 ? "even" : "odd";

            Console.WriteLine(result);
        }
    }
}