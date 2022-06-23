using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class PalString
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string rev = "";
            string orig =s;

            for(int i=s.Length-1;i>=0;i--)
            {
                rev = rev+s[i];
            }

            if(rev==s)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("no palindrome");
            }
        }
    }
}
