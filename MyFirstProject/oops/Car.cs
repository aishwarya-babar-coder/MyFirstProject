using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class Car
    {
       public  int  ModelNumber;
       public  string name;
       public string color;
       public double price;

        static void Main(string[]args)
        {
            Car c1 = new Car();

            c1.ModelNumber = 111;
            c1.name = "bmw";
            c1.color = "black";
            c1.price = 7888888;


            Console.WriteLine(c1.ModelNumber + "  " + c1.name + "  " + c1.color + "  " + c1.price);
            Console.WriteLine("------------------------------------------------------------------");


            Car c2 = new Car();

            c2.ModelNumber = 222;
            c2.name = "kia";
            c2.color = "white";
            c2.price = 71828888;

            Console.WriteLine(c2.ModelNumber + "  " + c2.name + "  " + c2.color + "  " + c2.price);
            Console.WriteLine("------------------------------------------------------------------");



            Car c3 = new Car();

            c3.ModelNumber = 333;
            c3.name = "creta";
            c3.color = "brown";
            c3.price = 7884568;

            Console.WriteLine(c3.ModelNumber + "  " + c3.name + "  " + c3.color + "  " + c3.price);
            Console.WriteLine("------------------------------------------------------------------");

        }
    }
}
