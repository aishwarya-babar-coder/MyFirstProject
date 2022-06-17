using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class LoopDemo
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("hello");
            }
        }
    }

    class LoopDemo2
    {
        static void Main(string[]args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class LoopDemo3
    {
        static void Main(string[] args)
        {
            int i = 1;
            for ( ; i <= 5; i++)
            {
                Console.WriteLine(i); 
            }
        }
    }

    class LoopDemo4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i >= 5; i++)
            {
                Console.WriteLine(i); //no op
            }
        }
    }

    class LoopDemo5
    {
        static void Main(string[]args)
        {
            for(int i=1; i<=5;)
            {
                Console.WriteLine(i); //infinit loop
            }
        }
    }

    class LoopDemo6
    {
        static void Main(string[]args)
        {
            for(int i=5;i<=1;i--)
            {
                Console.WriteLine(i); //no op
            }
        }
    }

  /*  class LoopDemo7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) ;
            {
                Console.WriteLine("hi"); //one time hi
            }
        }
    }*/

    class LoopDemo8
    {
        static void Main(string[]args)
        {
            for (int i = 1; i <= 5; i++)
                Console.WriteLine(i); // 1 2 3 4 5 hi
            Console.WriteLine("hi");
        }
    }

    class LoopDemo9
    {
        static void Main(string[]args)
        {
            for(int i=1; ;i++)
            {
                Console.WriteLine("hi"); //infinite loop
            }
        }
    }

    class LoopDemo10
    {
        static void Main(string[] args)
        {
            for (; ;)
            {
                Console.WriteLine("hi"); //infinite loop
            }
        }
    }

    class LoopDemo11
    {
        static void Main(string[] args)
        {
            for (int i=15;i<=25;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }


}
