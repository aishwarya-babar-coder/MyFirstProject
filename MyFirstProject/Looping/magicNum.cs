using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class magicNum
    {
        static void Main(string[]args)
        {
            int magic = 67;

            for(; ; )
            {
                Console.WriteLine("enter a number");
                int num = int.Parse(Console.ReadLine());

                if(num<magic)
                {
                    Console.WriteLine("number is less than magic number plz try again");
                    continue;
                }
                else if(num>magic)
                {
                    Console.WriteLine("number is greater than magic number plz try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("congratulations!!number is match");
                    break;
                }
            }
        }
    }
}
