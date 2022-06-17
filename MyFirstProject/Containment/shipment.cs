using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class OrderDate
    {
        int mm;
        int dd;
        int yy;
        public OrderDate(int mm,int dd,int yy)
        {
            this.mm = mm;
            this.dd = dd;
            this.yy = yy;
        }

        public void display1()
        {
            Console.Write(mm + " " + dd + " " + yy);
        }
    }
    class Order
    {
        int orderid;
        string custname;
        string city;

        public Order(int orderid,string custname,string city)
        {
            this.orderid = orderid;
            this.custname = custname;
            this.city = city;
        }

        public void display2()
        {
            Console.Write(" " + orderid + " " + custname + " " + city + " ");
        }
    }
    class shipment
    {
        int id;
        Order o;
        OrderDate od;
        public shipment(int id,Order o,OrderDate od)
        {
            this.id = id;
            this.o = o;
            this.od = od;
        }

        public void display3()
        {
            Console.Write(" " + id + " ");
            o.display2();
            od.display1();

        }

        static void Main(string[]args)
        {
            shipment s = new shipment(101, new Order(1, "ash", "pune"), new OrderDate(06, 13, 2022));
            s.display3();
        }
    }
}
