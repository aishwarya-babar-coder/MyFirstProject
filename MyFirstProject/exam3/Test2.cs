using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class Test2
    {
        static void Main(string[] args)
        {
            int[] var = new int[10];
            for (int i = 0; i < 10; ++i)
            {
                var[i] = i;
                Console.WriteLine(var[i] + " ");
                i++;

            }
        }
    }
}
