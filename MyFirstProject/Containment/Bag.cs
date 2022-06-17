using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Nib
    {
        string type;

        public Nib(string type)
        {
           this.type = type;
        }

        public void display1()
        {
            Console.Write(type + " ");
        }
    }
    class Pen
    {
        string name;
        string color;
        Nib n;

        public Pen(string name,string color,Nib n)
        {
            this.name = name;
            this.color = color;
            this.n = n;
        }
        public void display2()
        {
            Console.Write(" " + name + " " + color + " ");
            n.display1();
        }

    
    }
    class Bag
    {

        string brandname;
        string color;
        double price;
        Pen p;

        public Bag(string brandname, string color, double price, Pen p)
        {
            this.brandname = brandname;
            this.color = color;
            this.price = price;
            this.p = p;


        }
        public void display3()
        {
            Console.Write(" " + brandname + " " + color + " " + price + " ");
            p.display2();
            }

        static void Main(string[]args)
        {
            Bag b = new Bag("puma","black,",87657, new Pen("pilot", "blue", new Nib("metal")));
            b.display3();

        }
    }
}
