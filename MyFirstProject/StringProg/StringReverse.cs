using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class StringReverse
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string rev = "";

            char[] ch = s.ToCharArray();

            for(int i=ch.Length-1;i>=0;i--)
            {
                rev = rev + ch[i];
            }

            Console.WriteLine(string.Join(" ", rev));
        }
    }
}
