using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class CharDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'i', 's', 'h' };

            char[] ch1 = new char[4];

            Console.WriteLine("enter elements");
            for (int i = 0; i < ch1.Length; i++)
            {
                ch1[i] = Console.ReadLine()[0];
            }

            Console.WriteLine("display using normal loop");
            for (int i = 0; i < ch1.Length; i++)
            {
                Console.WriteLine(ch1[i]);
            }
            Console.WriteLine("----------------------");

            Console.WriteLine("display using for each loop");

            foreach (char x in ch1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("----------------------");

            Console.WriteLine("display using string.join()");

            Console.WriteLine(string.Join(" ", ch1));
        }
    }
}
