using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ThisConstr
    {
        public ThisConstr()
        {
            Console.WriteLine("default");
        }

        public ThisConstr(int x)
        {
            Console.WriteLine("x= " + x);
        }

        public ThisConstr(string city):this()
        {
            Console.WriteLine(city);
        }

        static void Main(string[]args)
        {
            ThisConstr t1 = new ThisConstr("pune");
        }
    }
}
