using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class VowCon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a char");
            char ch = Console.ReadLine()[0];

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
            {
                Console.WriteLine("vowels");
            }
            else
            {
                Console.WriteLine("consonents");
            }
        }
    }
}
