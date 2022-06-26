﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class SortByLength
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            string[] str = s.Split(" ");

            for(int i=0;i<str.Length;i++)
            {
                for(int j=i+1;j<str.Length;j++)
                {
                    if(str[i].Length>str[j].Length)
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;
                    }
                    else if(str[i].Length==str[j].Length)
                    {
                        if(str[i].CompareTo(str[j])==-1)//sorting according to asci value or lexographical
                        {
                            string temp1 = str[i];
                            str[i] = str[j];
                            str[j] = temp1;

                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", str));
        }
    }
}
