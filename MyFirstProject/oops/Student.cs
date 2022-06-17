using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class Student
    {
        int id;
        string name;
        double m1;
        double m2;
        double m3;

        double perc;
        public void AcceptDetails(int id1,string name1,double mm1, double mm2, double mm3)
        {
            id = id1;
            name = name1;
            m1 = mm1;
            m2 = mm2;
            m3 = mm3;
        }

        public void CalcPerc()
        {
            perc = ((m1 + m2 + m3) / 300) * 100;
        }

        public void Display()
        {
            Console.WriteLine("id  = "+id + "\nname = " + name + "\nenglish = " + m1 + "\nmaths = " + m2 + "\nhistory = " + m3+"\npercentage is "+perc);

        }
        static void Main(string[]args)
        {
            Student s1 = new Student();
            s1.AcceptDetails(101, "aishwarya", 80, 90, 78);
            s1.CalcPerc();
            s1.Display();
            
        }
    }
}
