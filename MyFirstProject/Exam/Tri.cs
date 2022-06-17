using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Tri
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());

            int cube = n * n * n; //cube

            while (n >  0)
            {
                if (n % 10 != cube % 10)
                {
                    Console.WriteLine("Not a Trimorphic number");
                    break;
                }

                n = n / 10;

                cube = cube / 10;
            }

            if (n == 0)
            {
                Console.WriteLine("Trimorphic number");
            }
        }
    }
}
