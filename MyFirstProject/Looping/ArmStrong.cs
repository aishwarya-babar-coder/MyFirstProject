using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class ArmStrong
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            int temp1 = n;
            int temp = n;

            int count = 0;
            while(n>0)
            {
                int rem = n % 10;
                count++;
                n = n / 10;
            }

            int sum = 0;
            while(temp>0)
            {
                int rem1 = temp % 10;
                sum = sum + (int)(Math.Pow(rem1, count));
                temp = temp / 10;
            }

            if(sum==temp1)
            {
                Console.WriteLine("armstrong");

            }
            else
            {
                Console.WriteLine("no armstrong");
            }
        }
    }
}
