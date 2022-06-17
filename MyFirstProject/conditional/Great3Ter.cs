using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class Great3Ter
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter first no");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second no");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter third no");
            int num3 = int.Parse(Console.ReadLine());

            string result = num1 > num2 ? num1 > num3 ? "first no is greater" : "third no is greater" : num2 > num1 ? num2 > num3 ? "second no is greater" : "third no is greater" :"third no is greater";

            Console.WriteLine(result);
        }
    }
}
