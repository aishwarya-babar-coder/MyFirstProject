using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class FindLongestWord
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();

            string[] s = str.Split();

            int maxlength = 0;

            //string longest = "";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i].Length>maxlength)
                {
                    maxlength = s[i].Length;
                   // longest = s[i];
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (maxlength == s[i].Length)
                {
                    Console.WriteLine(s[i]);
                }


            }
           // Console.WriteLine(longest + " " + maxlength);
        }
    }
}
