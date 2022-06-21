using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class MinChar
    {
        public void MinC(char []ch1)
        {
            char min = ch1[0];
            for(int i=0;i<ch1.Length;i++)
            {
                if (ch1[i] < min)
                {
                    min = ch1[i];
                }
            }
            Console.WriteLine(min);
        }
        static void Main(string[]args)
        {
            char[] ch = new char[5];
            Console.WriteLine("enter elements");
            for(int i=0;i<ch.Length;i++)
            {
                ch[i] = Console.ReadLine()[0];
            }

            MinChar m = new MinChar();
            m.MinC(ch);
        }
    }
}
