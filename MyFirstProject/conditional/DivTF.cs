using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class DivTF
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num %3==0 && num%9==0)
            {
                Console.WriteLine("number is divisible by 3 and 9");
            }
            else
            {
                Console.WriteLine("not divisible by 3 and 9");
            }
        }
    }
}
