using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class Demo2
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();

            int l = str.Length;
            Console.WriteLine(l);

            Console.WriteLine("---------------------");

            string newupper = str.ToUpper();
            Console.WriteLine(newupper);

            string newlower = str.ToLower();
            Console.WriteLine(newlower);

            char[] ch = str.ToCharArray();
            Console.WriteLine(string.Join(" ", ch));

            string substr = str.Substring(3);
            Console.WriteLine(substr);

            string sub2 = str.Substring(3, 5);//start index, no of char
            Console.WriteLine(sub2);

            Console.WriteLine(str[0] + "  " + str[str.Length - 1]);

            string[] words = str.Split(" ");

            foreach(string x in words)
            {
                Console.Write(x+" ");
            }

            Console.WriteLine();
            Console.WriteLine(str.IndexOf('i'));
            Console.WriteLine(str.LastIndexOf('a'));
        }
    }
}
