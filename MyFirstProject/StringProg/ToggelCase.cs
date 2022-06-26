using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class ToggelCase
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();
            string newcasestr = "";
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>='A'&& s[i]<='Z')
                {
                    newcasestr = newcasestr + (char)(s[i] + 32);
                }
                else if(s[i]>='a' && s[i]<='z')
                {
                    newcasestr = newcasestr + (char)(s[i] - 32);
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
