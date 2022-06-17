using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class MthodOverloading
    {
        void show()
        {
            Console.WriteLine("show");
        }

        void show(string s)
        {
            Console.WriteLine(s);
        }

        void show(int x)
        {
            Console.WriteLine(x);
        }

        void show(int x,int y)
        {
            Console.WriteLine(x+" "+y);
        }

        static void Main(string[]args)
        {
            MthodOverloading m1 = new MthodOverloading();
            m1.show();
            m1.show("ash");
            m1.show(10);
            m1.show(20,60);



        }
    }
}
