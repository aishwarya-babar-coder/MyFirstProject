using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class Engine
    {
        int engineid;
        string cleanDate;
        SubEngine s;

        public Engine(int engineid,string cleanDate,SubEngine s)
        {
            this.engineid = engineid;
            this.cleanDate = cleanDate;
            this.s = s;
        }
        public void display2()
        {
            Console.Write(engineid + " " + cleanDate + " ");
            s.display3();
        }
    }
    class SubEngine
    {
        string subEngineType;
        Gear g;
        public SubEngine(string subEngineType,Gear g)
        {
            this.subEngineType = subEngineType;
            this.g = g;
        }
        public void display3()
        {
            Console.Write(subEngineType + " ");
            g.display4();
        }
    }
    class Gear
    {
        string gearType;
        public Gear(string gearType)
        {
            this.gearType = gearType;
        }
        public void display4()
        {
            Console.Write(gearType + " ");
        }
    }
    class Car
    {
        int carid;
        string carcolor;
        Engine e;
   
        public Car(int carid,string carcolor,Engine e)
        {
            this.carid = carid;
            this.carcolor = carcolor;
            this.e = e;
        }

        public void display1()
        {
            Console.Write(carid + " " + carcolor + " ");
            e.display2();

        }
        static void Main(string[]args)
        {
            
            Car c = new Car(101, "black",new Engine(5,"18-6-20",new SubEngine("petrol",new Gear("auto-gear"))));
            c.display1();
        }
    }
}
