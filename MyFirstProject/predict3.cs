using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class predict3
    {
        static void Main(string[]args)
        {
            for(int i=5;i>0;i--)
            {
                int a = 100;
                a -= i;
                Console.WriteLine(a);
            }
        }
    }
}
