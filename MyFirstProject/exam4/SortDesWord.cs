using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class SortDesWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string []s = { "my", "name", "is", "ash", "i", "am", "very", "good", "girl", "yoo!!" };

            Console.WriteLine(string.Join(" ", s));

            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + " " + s[i];
            }
            Console.WriteLine(rev);
        }
    }
}
