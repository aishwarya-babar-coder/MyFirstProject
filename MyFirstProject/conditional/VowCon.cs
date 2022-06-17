using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class VowCon
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a character");
            char ch = Console.ReadLine()[0];

            if(ch=='a' ||  ch=='A')
            {
                Console.WriteLine("vowel");
            }
            else if(ch == 'e' || ch == 'E')
            {
                Console.WriteLine("vowel");
            }
            else if(ch == 'i' || ch == 'I')
            {
                Console.WriteLine("vowel");
            }
            else if(ch == 'o' || ch == 'O')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'U' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("consonent");
            }
        }
    }
}
