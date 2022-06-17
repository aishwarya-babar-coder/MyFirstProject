using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Kap
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());
            int sq = n * n;
            int temp = n, count=0;

            while (n>0)
            {
                count++; //count od digits present in a square of a number
                n = n / 10; //find no with remaining digit
            }

            int power = 1; //because we have to multiply 
            for(int i=1;i<=count;i++)// travel from 1 to count of digits
            {
                power = power*10; //calculate powers using base 10 
            }
            int div = sq / power; //
            int rem = sq % power;
            int sum = div+rem;
            if(sum==temp)
            {
                Console.WriteLine("kaprekar");
            }
            else
            {
                Console.WriteLine("not kaprekar");
            }
        }
    }
}
