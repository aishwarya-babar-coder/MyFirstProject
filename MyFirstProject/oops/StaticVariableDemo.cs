using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class StaticVariableDemo
    {
        int x = 10;
        static int y = 30;
        void add()
        {
            Console.WriteLine("addition is "+(x+y));
            y = 1;
            Console.WriteLine("addition is " + (x + y));
        }
        static void sum()
        {
            StaticVariableDemo s = new StaticVariableDemo();
            Console.WriteLine((s.x + y));


        }
        static void Main(string[]args)
        {
            StaticVariableDemo s = new StaticVariableDemo();
            s.add();
            StaticVariableDemo.sum();
        }
    }
}
