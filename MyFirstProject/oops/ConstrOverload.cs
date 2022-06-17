using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ConstrOverload
    {
        public ConstrOverload()
        {
            Console.WriteLine("non-arguments");
        }

        public ConstrOverload(int x)
        {
            Console.WriteLine(x);
        }

        public ConstrOverload(int x,int y)
        {
            Console.WriteLine(x+" "+y);
        }

        public ConstrOverload(string s)
        {
            Console.WriteLine(s);
        }

        static void Main(string[]args)
        {
            ConstrOverload c1 = new ConstrOverload();
            ConstrOverload c2 = new ConstrOverload(5);
            ConstrOverload c3 = new ConstrOverload(5,6);
            ConstrOverload c4 = new ConstrOverload("aishwarya");


        }
    }
}
