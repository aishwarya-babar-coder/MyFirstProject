using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class AreaOverload
    {
        void area(int length, int breadth)
        {
            Console.WriteLine("area of rectangle is " + (length * breadth));
        }

        void area(int side)
        {
            Console.WriteLine("area of square is " + (side * side));
        }

        void area(double radius)
        {
            Console.WriteLine("area of circle is " + (3.14*radius*radius));
        }

        void area(double bas,double height)
        {
            Console.WriteLine("area of triangle is " + (0.5*bas*height));
        }
        static void Main(string[]args)
        {
            AreaOverload a1 = new AreaOverload();
            a1.area(5,10);
            a1.area(8);
            a1.area(4);
            a1.area(10,4);



        }
    }
}
