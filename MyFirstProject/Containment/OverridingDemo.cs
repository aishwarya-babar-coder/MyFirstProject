using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    abstract class vehical
    {
        public abstract void run();

        public vehical(string name)
        {
            Console.WriteLine("carname = " + name);
        }

        public void show()
        {
            Console.WriteLine("show method");
        }
        
    }
    class car:vehical
    {
        public car() : base("audi") //parent constructor call from child constructor
        {
            Console.WriteLine("my car");
        }
        public override void run()
        {
            Console.WriteLine("car is running");
        }
    }
    
    class OverridingDemo
    {
        static void Main(string[]args)
        {
            // car c = new car();//object of child class
            //c.run();
            vehical v = new car();//upcasting
            v.run();
            v.show();


        }
    }
}
