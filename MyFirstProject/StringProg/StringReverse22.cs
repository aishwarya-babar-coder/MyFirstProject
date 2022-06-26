using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class StringReverse22
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string rev = "";

            for(int i=s.Length-1;i>=0;i--)
            {
                rev = rev + s[i];
            }

            Console.WriteLine(rev);

            string rev1 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev1 =  s[i]+rev1;
            }
            Console.WriteLine(rev1);
        }
    }
}
