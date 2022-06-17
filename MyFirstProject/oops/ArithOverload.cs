using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ArithOverload
    {
        void calculate(int a,int b)
        {
            Console.WriteLine("addition is " + (a + b));
        }
        void calculate()
        {
            int a = 100;
            int b = 30;
            Console.WriteLine("subtraction is "+(a - b));
        }
        void calculate(float a,double b)
        {
            Console.WriteLine("multiplication is " + (a * b));
        }
        void calculate(double a,double b)
        {
            Console.WriteLine("division is " + (a / b));
        }

        static void Main(string[] args)
        {

            ArithOverload a = new ArithOverload();
            a.calculate(100,50);
            a.calculate();
            a.calculate(8.0f,3.0);
            a.calculate(200.00,10.00);
        }
    }
}
