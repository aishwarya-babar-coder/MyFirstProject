using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Loan
    {
        public void display1()
        {
            Console.WriteLine("common loan");
        }
    }
    class homeLoan:Loan
    {
        public void display2()
        {
            Console.WriteLine("homeloan");
        }
    
    }
    class carLoan : Loan
    {
        public void display3()
        {
            Console.WriteLine("car loan");
        }
    }
    class goldLoad:Loan
    {
        public void display4()
        {
            Console.WriteLine("gold loan");
        }
    }
    class Hier
    {
        static void Main(string[]args)
        {
            Loan l = new Loan();
            l.display1();

            homeLoan h = new homeLoan();
            h.display1();
            h.display2();

            carLoan c = new carLoan();
            c.display1();
            c.display3();

            goldLoad g = new goldLoad();
            g.display1();
            g.display4();
        }
    }
}
