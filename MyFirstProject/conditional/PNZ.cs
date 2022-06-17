using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class PNZ
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            if(num>0)
            {
                Console.WriteLine("positive");
            }
            else if(num<0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }
    }
}
