using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class dis
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a no");
            int n = int.Parse(Console.ReadLine());

            int count=0;
            int sum = 0;
            int temp = n;

            while(temp>0)
            {
                count++; //count the digits in a no
                temp = temp / 10; //to get the remaining no
            }
            //
            temp = n;
            while(temp>0)
            {
                int rem = temp % 10;
                sum = sum + (int)(Math.Pow(rem, count));
                temp = temp / 10;
                count--;

            }

            if(n==sum)
            {
                Console.WriteLine("disarium no");
            }
            else
            {
                Console.WriteLine("no disarium no");
            }

           
        }
    }
}
