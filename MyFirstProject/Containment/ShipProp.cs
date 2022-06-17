using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class OrderDatee
    {
        int mm;
        int dd;
        int yy;

        public int Mm { get { return mm; } set { mm = value; } }
        public int Dd { get { return dd; } set { dd = value; } }
        public int Yy { get { return yy; } set { yy = value; } }
    }
    class Orderr
    {
        int orderid;
        string custname;
        string city;

        public int Orderid { get => orderid; set => orderid = value; }
        public string Custname { get => custname; set => custname = value; }
        public string City { get => city; set => city = value; }
    }
    class ShipProp
    {
        int id;
        Orderr o;
        OrderDatee od;

        public int Id { get => id; set => id = value; }
       public Orderr O { get { return o; } set { o = value; } }
        public OrderDatee Od { get => od; set => od = value; }

        static void Main(string[]args)
        {
            ShipProp s = new ShipProp();
            s.Id = 101;
            s.O = new Orderr();
            s.O.Orderid = 2;
            s.O.Custname = "ash";
            s.O.City = "pune";
            s.Od = new OrderDatee();
            s.Od.Mm = 6;
            s.Od.Dd = 1;
            s.Od.Yy = 2022;

            Console.WriteLine(s.Id + " " + s.O.Orderid + " " + s.O.Custname + " " + s.O.City + " " + s.Od.Mm + " " + s.Od.Dd + " " + s.Od.Yy);

        }
    }
}
