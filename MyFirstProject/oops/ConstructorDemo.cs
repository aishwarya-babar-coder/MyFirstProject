using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ConstructorDemo
    {
        public ConstructorDemo()
        {
            Console.WriteLine("default");
        }

        public ConstructorDemo(int x)
        {
            Console.WriteLine(x);
        }

        public void get()
        {

        }
        static void Main(string[] args)
        {
            ConstructorDemo c1 = new ConstructorDemo();
            ConstructorDemo c2 = new ConstructorDemo(567);
            c1.get();
        }
    }
}
