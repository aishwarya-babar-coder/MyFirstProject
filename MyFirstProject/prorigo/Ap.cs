using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.prorigo
{
    class Ap
    {
        static void Main(string[]args)
        {
            int a2 = int.Parse(Console.ReadLine());
            int a3 = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());

            int d = a3 - a2; //find out difference between 2nd and 3rd term

            for(int i=4;i<=n;i++)
            {
                a3 = a3 + d;
                Console.Write(a3+"  ");
            }
            
        }
    }
}
