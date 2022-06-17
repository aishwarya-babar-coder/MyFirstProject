using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class EvenSum
    {
        static void Main(string[]args)
        {
            int sum = 0;
            for(int i=1;i<=10;i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("sum of even nos between 1 to 10 is " + sum);
        }
    }
}
