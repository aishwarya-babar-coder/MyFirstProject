using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class CountWords
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string[] s1 = s.Split(" ");
            int count = 0;
            for(int i=0;i<s1.Length;i++)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
