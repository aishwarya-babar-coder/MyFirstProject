using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ThisMethodcs
    {
        int x;
       

        public void get(int x)
        {
            this.x = x;
            //this.show();
        }
        public void show()
        {
            get(45);
            Console.WriteLine(x);
        }
        static void Main(string[]args)
        {
            ThisMethodcs t1 = new ThisMethodcs();
            //t1.get(89);
            t1.show();
        }

    }
}
