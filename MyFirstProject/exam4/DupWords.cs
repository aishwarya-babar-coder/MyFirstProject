using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam4
{
    class DupWords
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string[] s1 = s.Split();

            for(int i=0;i<s1.Length;i++)
            {
                int count = 1;
                bool isvisit = false;

                for(int k=i-1;k>=0;k--)
                {
                    if(s1[i]==s1[k])
                    {
                        isvisit = true;
                        break;
                    }
                }
                if (isvisit == false)
                {
                    for (int j = i + 1; j < s1.Length; j++)
                    {
                        if (s1[i] == s1[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine(s1[i] + "  " + count);
                    }
                }
            }
        }
    }
}
