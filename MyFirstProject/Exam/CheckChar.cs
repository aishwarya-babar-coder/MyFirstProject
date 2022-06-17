using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class CheckChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a character");
            char ch = Console.ReadLine()[0];

            if (ch >= 'a')
            {
                if (ch <= 'z')
                {
                    Console.WriteLine("alphabet");
                }
            }
            else if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("alphabet");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("symbol");
            }
        }
    }
}
