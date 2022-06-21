using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class Test
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        static void Main(string []arg)
        {
            Console.WriteLine(mcCarthy(100) + "  " + mcCartyCounter);

        }
    } 
}

