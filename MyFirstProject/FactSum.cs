using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class FactSum
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter range");
            int range = int.Parse(Console.ReadLine());
            int sum = 0;
            int fact= 1;
            for(int i=1;i<=range;i++)
            {
                
                    fact = fact * i;
                    sum = sum + fact;
                
               
            }
            Console.WriteLine(sum);
        }
    }
}
