using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class ser
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter range");
            int n = int.Parse(Console.ReadLine());

            for(int i=1;i<=n;i++)
            {
                int res = (i*i) + (i * i * i);
                Console.WriteLine(res);
            }
            
        }
    }
}
