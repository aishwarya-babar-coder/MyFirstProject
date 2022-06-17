using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class device
    {
        public void display1()
        { Console.WriteLine("this is a device"); }
    }
    class laptop:device
    {
        public void display2()
        {
            Console.WriteLine("this is a laptop");
        }
    }

    class dwell:laptop
    {
        public void display3()
        {
            Console.WriteLine("this is dwell laptop");
        }
    }

    class multi
    {
        static void Main(string[]args)
        {
            dwell d = new dwell();
            d.display3();
            d.display2();
            d.display1();

            laptop l = new laptop();
            l.display2();
            l.display1();

            device dv = new device();
            dv.display1();
        }
    }

}
