using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Loop
    {
        static void Main(string[]args)
        {
            int b = 0;
            do
            {
                int a = 2; //everytime initialization of a because a initialized in a do block
                b++; //b=0  1  2
                Console.WriteLine(a++); //2 2 2
            }
            while (b != 3);  //1!=3 2!=3 3!=3
            

            
        }
    }
}
