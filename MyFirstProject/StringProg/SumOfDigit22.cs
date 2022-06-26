using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class SumOfDigit22
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            int count = 0;
            int sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    int x = (int)char.GetNumericValue(s[i]); ;
                    count++;
                    sum = sum + x;
                }
            }
            Console.WriteLine("count= " + count);
            Console.WriteLine("sum= " + sum);
        }
    }
}
