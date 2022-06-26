using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class UpperToLower
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string newstr = " ";
            for(int i=0;i<s.Length;i++)
            {   
                if(char.IsUpper(s[i]))
                {
                    newstr = newstr + char.ToLower(s[i]);
                }
                else
                {
                    newstr = newstr + s[i];
                }
            }

            Console.WriteLine(newstr);
        }
    }
}
