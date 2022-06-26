using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class StringCompareDemo
    {
        static void Main(string[]args)
        {
            string s1 = "hello";
            string s2 = "Hello";

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));
        }
    }
}
