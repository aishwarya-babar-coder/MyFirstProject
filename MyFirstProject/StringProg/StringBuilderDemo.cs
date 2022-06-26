using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class StringBuilderDemo
    {
        static void Main(string[]args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");   //append is used to join string
            Console.WriteLine(sb);
            sb.Append("program");
            Console.WriteLine(sb);

            StringBuilder sb2 = new StringBuilder("pune");
            Console.WriteLine(sb2);
            string s = "india";
            StringBuilder sb3 = new StringBuilder(s);
            sb3.Append(" ");
            sb3.Append("contry");
            Console.WriteLine(sb3);

            sb3.Insert(6, "my"); //insert string at specifoc index
            Console.WriteLine(sb3);

            sb3.Remove(3, 4);
            Console.WriteLine(sb3);

            StringBuilder s1 = new StringBuilder("hello");
            StringBuilder s2 = new StringBuilder("hello");

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));

        }
    }
}
