using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class Demo
    {
        static void Main(string[] args)
        {
            string s = "hello";//using keyword
            String str = "hello";//using literal
            String st = new String("hello"); //using new

            Console.WriteLine(s == st);
            Console.WriteLine(s == str);

            Console.WriteLine(str.GetHashCode());

            str = str + "c#";
            Console.WriteLine(str);
            Console.WriteLine(str.GetHashCode());



        }
    }
}
