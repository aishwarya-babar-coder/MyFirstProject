using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class employee
    {
        int id;
        string name;
        double salary;

        public employee(int eid,string ename,int esal)
        {
            id = eid;
            name = ename;
            salary = esal;
        }

        void Display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }

        static void Main(string[]args)
        {
            employee e1 = new employee(101,"ash",25000);
            e1.Display();
        }
    }
}
