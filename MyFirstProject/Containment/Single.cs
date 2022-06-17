using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class tv
    {
        public static int price = 100000;
         public void display1()
        {
            Console.WriteLine("this is a tv");
            Console.WriteLine("tv price is " + price);
        }
    }

    class LG:tv
    {
        public static int pric = 897655;
      
         public void display2()
        { 
            Console.WriteLine("this is LG brand");
            Console.WriteLine("price of LG is "+pric);
        }
    }
    class Single
    {
        static void Main(string[]args)
        {
            LG l = new LG();
            l.display1();
            l.display2();
        }
    }
}
