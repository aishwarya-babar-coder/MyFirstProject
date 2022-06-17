using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class StaticDemo
    {
        /*int count = 0;

        public StaticDemo()
        {
            count++;
            Console.WriteLine(count);
        }

       */
        static int count = 0;
        int x = 10;

        public StaticDemo()
        {
            count++;
            Console.WriteLine(count);
        }
      
        static void Main(string[]args)
        {
            StaticDemo s1 = new StaticDemo();
            StaticDemo s2 = new StaticDemo();
            StaticDemo s3 = new StaticDemo();
        }
    }
}
