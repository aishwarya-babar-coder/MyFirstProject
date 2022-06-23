using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class SortString
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            char[] ch = s.ToCharArray();

            for(int i=0;i<ch.Length;i++)
            {
               for(int j=i+1;j<ch.Length;j++)
                {
                    if(ch[i]>ch[j])
                    {
                        char temp = ch[i];
                        ch[i] = ch[j];
                        ch[j] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", ch));
        }
    }
}
