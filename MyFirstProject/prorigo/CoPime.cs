using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.prorigo
{
    class CoPime
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter no");
            int n = int.Parse(Console.ReadLine());

            int gcd = 0; //greatest common divisor
            int count = 0; //count of gcd 

            for(int i=1;i<=n;i++) //1 to n
            {
                for(int j=1;j<=i;j++) //j should be each no
                {
                    if(i%j==0 && n%j==0) //calculate each no factor, and lastno factor
                    {
                        gcd = j;  
                    }
                }
                if(gcd==1)
                {
                    count++;
                }
            }
            Console.WriteLine("number of coprimes upto "+n+" is "+count);
        }
    }
}
