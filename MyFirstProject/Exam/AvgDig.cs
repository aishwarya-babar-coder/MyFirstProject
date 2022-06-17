using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class AvgDig
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a no");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            double avg;
            while(n>0)
            {
                int rem = n % 10;
                count++;
                sum = sum + rem;
                n = n / 10;
            }

            avg = Convert.ToDouble(sum) / count;

            Console.WriteLine(avg);
        }
    }
}
