using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class atmcard
    {
        public void display1()
        {
            Console.WriteLine("atmcard");
        }
    }

    class mastercard:atmcard
    {
        public void display2()
        {
            Console.WriteLine("mastercard");
        }
    }

    class visa : atmcard
    {
        public void display3()
        {
            Console.WriteLine("visa");
        }
    }

    class rupay:atmcard
    {
        public void display4()
        {
            Console.WriteLine("rupay");
        }
    }
    class hier2
    { 
        static void Main(string[]args)
        {
            atmcard a = new atmcard();
            a.display1();

            mastercard m = new mastercard();
            m.display1();
            m.display2();

            visa v = new visa();
            v.display1();
            v.display3();

            rupay r = new rupay();
            r.display1();
            r.display4();
        }
    }
}
