using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class ReverseWord
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string[] words = s.Split(" ");

            string rev = "";
            for(int i=words.Length-1;i>=0;i--)
            {
                rev = rev +" "+ words[i];
            }

            Console.WriteLine(rev);
        }
    }
}
