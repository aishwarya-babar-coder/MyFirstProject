using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Studentt
    {
        public int marks = 78;
        public void get(string name)
        {
            Console.WriteLine("student" + name);
        }
    }
    class Teacher:Studentt
    {
        public int marks = 90;
        public void show()
        {
            Console.WriteLine(marks + " " + base.marks); //base keyword is used to access parent class variable of same name
        }
        public void get()
        {
            base.get(" ash");//base keyword is used to access parent method of same name
            Console.WriteLine("teacher");
        }
    }
    class ParentVariable
    {
        static void Main(string[]args)
        {
            Teacher t = new Teacher();
            t.show();
            t.get();
        }
    }
}
