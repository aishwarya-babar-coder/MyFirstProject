using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.prorigo
{
    class Scope
    {
        int x = 10;
        static int y = 20;
        static void Main(string[]args)
        {
            int x = 100;
            int y = 200;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(Scope.y);
        }
    }
}
