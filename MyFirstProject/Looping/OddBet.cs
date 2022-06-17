using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class OddBet
    {
        static void Main(string[]args)
        {
            Console.WriteLine("odd numbers between 15 to 30 is");
            for(int i=15;i<=30;i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
