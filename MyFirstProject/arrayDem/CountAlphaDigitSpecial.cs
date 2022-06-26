using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class CountAlphaDigitSpecial
    {

        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string s = Console.ReadLine();

            int alpha = 0;
            int dig = 0;
            int special = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]>='a' && s[i]<='z')
                {
                    alpha++;
                }
                else if(s[i]>='A'&& s[i]<='Z')
                {
                    alpha++;
                }
                else if(s[i]>='0' && s[i]<='9')
                {
                    dig++;
                }
                else if(s[i]== '#' || s[i]=='@' || s[i]=='$' || s[i]=='%')
                {
                    special++;
                }
                
                
            }
            Console.WriteLine("alphabets = " + alpha);
            Console.WriteLine("digits = " + dig);
            Console.WriteLine("special characters = " + special);
        }
    }
}
