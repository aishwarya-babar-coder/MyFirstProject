using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class exam
    {
        private string name;
        private string breed;
        private int price;
        private string size;
        private string color;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Breed
        {
            get
            {
                return breed;
            }
            set
            {
                breed = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        static void Main(string[]args)
        {
            exam e = new exam();
            e.Name ="cookie";
            e.Breed = "golden retriever";
            e.Price = 1234567;
            e.Size = "big";
            e.Color = "golden";

            Console.WriteLine(e.Name + " " + e.Breed + " " + e.Price + " "+e.Size + " " + e.Color);
        }
    }
}
