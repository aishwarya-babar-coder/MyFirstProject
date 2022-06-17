using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class school
    {
        public string name = "hujurpaga";
        public void display1()
        {
            Console.WriteLine("school name is " + name);
        }
    }

    class student:school
    {
        public string name = "aishwarya";

        public void display2()
        {
            Console.WriteLine("student name is " + name);
        }
    
    }
    class single2
    {
        
        static void Main(string[]args)
        {
            student s = new student();
            s.display1();
            s.display2();
        }
    }
}
