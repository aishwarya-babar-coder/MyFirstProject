using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class SumPrime
    {
        static void Main(string[] args)

        {
            int count, sum = 0;
            for (int n = 1; n <= 10; n++)
            {
                count = 0;
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && n != 1)
                {
                    sum = sum + n;
                }
            }
            Console.WriteLine("sum of prime nos between 1 to 10 is " + sum);

        }

    }       
     
}
