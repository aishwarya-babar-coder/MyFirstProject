using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class ToggleCase22
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string newcasestr = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    newcasestr = newcasestr + char.ToLower(s[i]);
                }
                else if (char.IsLower(s[i]))
                {
                    newcasestr = newcasestr + char.ToUpper(s[i]);
                }
                else
                {
                    newcasestr = newcasestr + s[i];
                }
            }
            Console.WriteLine(newcasestr);
        }
    }
}
