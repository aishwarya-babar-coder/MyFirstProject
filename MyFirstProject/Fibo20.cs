using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Fibo20
    {
        static void Main(string[]args)
        {
            int n1 = 0;
            int n2 = 1;

            Console.Write(n1 + " " + n2 + " ");

            int temp;
            for(int i=2;i<=20;i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                temp = n1;
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
