using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class PatternString
    {
        public static void pat(string s1)
        {
            string[] s2 = s1.Split(" ");
            for(int i=0;i<s2.Length;i++)
            {
                string c = "";
                for(int j=0;j<=i;j++)
                {
                    c = c + " "+s2[j];
                }
                Console.WriteLine(c);
            }
        }
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            pat(s);
        }
    }
}
