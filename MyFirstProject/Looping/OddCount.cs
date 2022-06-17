using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class OddCount
    {
        static void Main(string[]args)
        {
            Console.WriteLine("odd numbers between 1 to 20 are");
            int count = 0;
            for(int i=1;i<=20;i++)
            {
                if(i%2!=0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("count of odd nos between 1 to 20 is " + count);
        }
    }
}
