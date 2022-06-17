using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class SimpleInterest
    {
        static void Main(string[]args)
        {
            int principle = 100, time = 2, rate = 3;
            double SI = (principle * time * rate)/100;
            Console.WriteLine("simple interest is " + SI);


        }
    }
}
