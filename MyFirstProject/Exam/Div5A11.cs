using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Div5A11
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            if(n%5==0 && n%11==0)
            {
                Console.WriteLine("no is divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("no is not divisible by 5 and 11");
            }
        }
    }
}
