using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class mobile
    {
        string memory = "64gb";
        public mobile(int x)
        {
            Console.WriteLine("mobile memory= " + memory + " " + x);
        }
    }
    class apple : mobile
    {
        public apple(int y):base(128) //base keyword is used to fetch parent class constructor
        {
            Console.WriteLine("apple");
        }
    }
    class BasecConstructorDemo
    {
        static void Main(string[]args)
        {
            apple a = new apple(890);
        }
    }
}
