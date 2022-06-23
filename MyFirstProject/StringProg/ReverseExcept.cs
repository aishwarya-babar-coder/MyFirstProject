using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class ReverseExcept
    {
        public static void Rev(string str)
        {
            string[] s1 = str.Split(" ");
            string revss = "";
            for (int i = 0; i < s1.Length; i++)
            {
                if (i == 0 || i == s1.Length - 1)
                {
                    revss = revss +" "+ s1[i];
                }
                else
                {
                    string word = s1[i];
                    string revs = "";
                    for (int j = word.Length - 1; j >= 0; j--)
                    {
                        revs = revs + word[j];

                    }

                    revss = revss + " " + revs;
                }
            }
            Console.WriteLine(revss);
        }
           
        
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            Rev(s);
        }
    }
}
