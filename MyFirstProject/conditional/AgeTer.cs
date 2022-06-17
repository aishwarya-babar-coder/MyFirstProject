using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class AgeTer
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());

            string teen = age >= 13? age <= 19 ? "teenager" : "no teenager":"no teenager";

            Console.WriteLine(teen);
        }
    }
}
