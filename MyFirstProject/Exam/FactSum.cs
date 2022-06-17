using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class FactSum
    {
        static void Main(string[]args)
        {
            int fact = 1;
            int sum = 0;

            for (int range = 1; range <= 5; range++)
            {
               
                    fact = fact * range;
                    sum = sum + fact; 
            }  
            Console.WriteLine(sum);
        }
    }

}
