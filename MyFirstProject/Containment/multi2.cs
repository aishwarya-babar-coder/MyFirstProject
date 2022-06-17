using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class animal
    {
        public void display1()
        {
            Console.WriteLine("this is animal");
        }
    }
    class pet:animal
    {
        public void display2()
        {
            Console.WriteLine("this can be pet");
        }
    }
    class cat:pet
    {
        public void display3()
        {
            Console.WriteLine("this is cat");
        }
    }
    class multi2
    {
        static void Main(string[]args)
        {
            cat c = new cat();
            c.display3();
            c.display2();
            c.display1();

            pet p = new pet();
            p.display2();
            p.display1();
        }
    }
}
