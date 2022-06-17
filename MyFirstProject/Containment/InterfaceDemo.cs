using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
   public interface Iprintable //super interface
    {
        void run(); //incomplete method
    }

    public interface Imovable //super interface
    {
        public static int x = 67;
        void show(); //incomplete method

        static void move()
        {
            Console.WriteLine("move");
        }
        internal void foo()
        {
            Console.WriteLine(":foo");
        }
    }
    class InterfaceDemo:Imovable,Iprintable //child interface :multiple interface
    {
        public void show()//complete method of imovable
        {
            Console.WriteLine("show method " + Imovable.x);
        }
        public void run() //complete method of iprintable
        {
            Console.WriteLine("run");
        }
        static void Main(string[]args)
        {
            Imovable m = new InterfaceDemo(); //upcasting
            m.show();
            Imovable.move();
            m.foo();
            Iprintable p = new InterfaceDemo();
            p.run();
        }
    }
}
