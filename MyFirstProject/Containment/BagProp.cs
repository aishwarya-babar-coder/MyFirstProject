using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Nibb
    {
        string typee;
        public string Typee
        {
            get { return typee; }
            set { typee = value; }
        }
        public void display1()
        {
            Console.Write(Typee + " ");
        }
    }

    class Penn
    {
        string pname;
        string pcolor;
        Nibb n;

        public string Pname { get { return pname; } set { pname = value; } }
        public string Pcolor
        {
            get { return pcolor; }
            set { pcolor = value; }
        }

        public Nibb N
        {
            get { return n; }
            set { n = value; }
        }

        public void display2()
        {
            n.display1();
        }
    }
        class BagProp
        {
            string brandname;
            string color;
            double price;
            Penn p;

            public string Brandname { get { return brandname; } set { brandname = value; } }
            public string Color { get { return color; } set { color = value; } }
            public double Price { get { return price; } set { price = value; } }
            Penn P { get { return p; } set { p = value; } }

            static void Main(string[] args)
            {
                BagProp b = new BagProp();
                b.Brandname = "puma";
                b.Color = "black";
                b.Price = 678;
                b.P = new Penn();
                b.P.Pname = "pilot";
                b.P.Pcolor = "blue";
                b.P.N = new Nibb();
                b.P.N.Typee = "metal";

                Console.WriteLine(b.Brandname +" "+b.Color+" "+b.Price+" "+b.P.Pname+" "+b.p.Pcolor+" "+b.P.N.Typee);
               
            }
        }
    }

