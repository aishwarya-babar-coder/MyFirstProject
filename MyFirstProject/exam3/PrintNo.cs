using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class PrintNo
    {
        static void Main(string[]args)
        {
            int buzz = 0;
            int fizz = 0;
            int buzzfizz = 0;
            for(int i=1;i<=50;i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    buzzfizz++;
                    Console.WriteLine("buzzfizz");
                }
                else if(i%3==0)
                {
                    buzz++;
                    Console.WriteLine("buzz");
                }
                else if(i%5==0)
                {
                    fizz++;
                    Console.WriteLine("fizz");
                }
               
                
            }
              Console.WriteLine("buzz printed " + buzz + " times");
              Console.WriteLine("fizz printed " + fizz + " times");
              Console.WriteLine("buzzfizz printed " + buzzfizz + " times");

        }
    }
}
