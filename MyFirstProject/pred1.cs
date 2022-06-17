using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class pred1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=4;i++)
            {
                for(int j=4-i;j>=1;j--)
                {
                    Console.Write(" ");
                }
                
                for(int k=1;k<=2*i-1;k++)
                {
                    Console.Write(i);
                }
                
                Console.WriteLine();
            }
        }
    }
}
