using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class CharMax
    {
        public void max(char []ch)
        {
            char max = ch[0];
            for(int i=0;i<ch.Length;i++)
            {
                if(ch[i]>max)
                {
                    max = ch[i];
                }
            }
            Console.WriteLine(max);
        }

        static void Main(string[]args)
        {
            char[] a = new char[5];
            Console.WriteLine("enter elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Console.ReadLine()[0];
            }
            CharMax c = new CharMax();
            c.max(a);
        }
    }
}
