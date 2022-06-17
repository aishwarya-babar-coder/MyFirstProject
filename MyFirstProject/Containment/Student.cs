using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Student
    {
        int id;
        string name;
        float perc;
        bool isplaced;

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public double Salary
        {
            get;
            set;
        }

        public float Perc
        {
            get;
            set;
        }

        public bool Isplaced
        {
            get;
            set;
        }



        static void Main(string[]args)
        {
            Student s = new Student();
            s.Id = 101;
            s.Name = "ash";
            s.Perc = 90.2f;
            s.Isplaced = true;

            Console.WriteLine(s.Id + " " + s.Name + " " + s.Perc+" "+s.Isplaced);
        }
    }
}
