using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class ThisAll
    {
        int id;
        string name;
        int age;
        string address;
        double marks;

        public ThisAll(int id, string name, int age):this(86.89)
        {
            this.id = id;
            this.name = name;
            this.age = age;

            this.Display(id,name,age);
        }

        public void Display(int id,string name, int age)
        {
            Console.WriteLine("id is " + id + "\nname is " + name + " \nage is " + age);
        }

        public ThisAll()
        {
       
        }
        public ThisAll(string address):this()
        {
            this.address = address;
            Console.WriteLine("address is "+address);
        }

        public ThisAll(double marks) : this("sinhgad road")
        {
            this.marks = marks;
            Console.WriteLine("marks is "+marks);
        }

        static void Main(string[]args)
        {
            ThisAll t1 = new ThisAll(101, "aishwarya", 24);

        }
    }
}
