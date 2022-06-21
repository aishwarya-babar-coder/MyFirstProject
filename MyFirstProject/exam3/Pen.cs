using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class Refill
    {
        private string inkcolor;
        private int length;
        private string nib;

        public string Inkcolor { get { return inkcolor; } set { inkcolor = value; } }
        public int Length { get { return length; } set { length = value; } }
        public string Nib { get { return nib; } set { nib = value; } }
    }
    class Pen
    {
        private Refill refill;
        private int caplength;
        private string brand;

        public int Caplength { get { return caplength; } set { caplength = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public Refill Refill { get{return refill;}set { refill = value; } }

        static void Main(string[]args)
        {
            Pen p = new Pen();
            p.refill = new Refill();
            p.refill.Inkcolor ="blue";
            p.refill.Length = 5;
            p.refill.Nib = "metal";
            p.Brand = "pilot";
            p.Caplength = 3;

            Console.WriteLine(p.refill.Inkcolor + "  " + p.refill.Length + "  " + p.refill.Nib + " " + p.Brand + " " + p.Caplength);


        }
    }
}
