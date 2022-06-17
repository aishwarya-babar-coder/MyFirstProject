using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ThisVariable
    {
        int x;
        public ThisVariable(int x)
        {
            this.x = x;
        }

        public void show()
        {
            Console.WriteLine(x);
        }
        static void Main(string[]args)
        {
            ThisVariable t1 = new ThisVariable(89);
            t1.show();
        }
    }
}
