using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class CBDemo1
    {
        static void Main(string[] args)
        { 

        for(int i=1;i<=5;i++)
         {
             if(i==3)
                {
                    break;//used to stop execution
                }
                Console.WriteLine(i);

         }
        }
    }

    class CBDemo2
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                {
                    continue;//used to skip execution or iteration
                }
                Console.WriteLine(i);

            }
        }
    }

    class CBDemo3
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++)
            {
                if (i == 3 || i==5 || i==7)
                {
                    continue;//used to skip execution or iteration
                }
                Console.WriteLine(i);

            }
        }
    }
}
