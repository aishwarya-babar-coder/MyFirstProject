using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Car
    {

        private int modelno;
        private string name;
        private string color;
        private int price;

        public int Modelno
        {
            get
            {
                return modelno;
            }

            set
            {
                modelno = value;
            }
        }

        public string Name
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }
        public int Price
        {
            get;
            set;
        }
    }
        class CarInfo
        {
            static void Main(string[] args)
            {
                Car c = new Car();
                c.Modelno = 2344;
                c.Name = "AUDI";
                c.Color = "BLACK";
                c.Price = 5678990;

                int NUM = c.Modelno;

                Console.WriteLine(c.Modelno + " " + c.Name + "" + c.Color + "" + c.Price);

            }
        }
}
