using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Employee
    {
        int id;
        string name;
        double salary;

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

    
        static void Main(string[]args)
        {
            Employee E = new Employee();
            E.Id = 101;
            E.Name = "ash";
            E.Salary = 909.90;

            Console.WriteLine(E.Id+" "+E.Name+" "+E.Salary);

        }
    }

}
