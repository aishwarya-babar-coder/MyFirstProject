using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Car
    {
        private int modelno;
        private string name;
        private int price;
        private string engine;

        public int Modelno
        {
            get {return modelno; }
            set { modelno=value ; }
            
        }
        public string Name
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
            
        }

        public string Engine
        {
            get;

            set;
            
        }

        static void Main(string[]args)
        {
            Car c = new Car();
            c.Modelno = 101;
            c.Name = "kia";
            c.Price = 90987;
            c.Engine = "petrol";

            Console.WriteLine(c.Modelno + " " + c.Name + " " + c.Price + " " + c.Engine);
        }

    }
}
