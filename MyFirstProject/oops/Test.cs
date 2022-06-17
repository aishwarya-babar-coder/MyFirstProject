using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class Test
    {
        static int x = 10;
        void get(int x)
        {
            //x=x;
            Test.x = x;
        }

        void show()
        {
            Console.WriteLine(x);
        }
        static void Main(string[]args)
        {
            Test t1 = new Test();
            t1.get(450);
            t1.show();
        }
    }
}
