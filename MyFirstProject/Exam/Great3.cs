using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Great3
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int max;
            if(num1>num2 && num1>num3)
            {
                max = num1;
            }
            else if(num2>num1 && num2>num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            Console.WriteLine("greatest number is "+max);
        }
    }
}
