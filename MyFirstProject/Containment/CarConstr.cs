using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Engine
    {
        string type;

        public Engine(string type)
        {
            this.type = type;
        }
        public void show()
        {
            Console.WriteLine(" " + type);
        }
    }
    class CarConstr
    {
        int modelno;
        string name;
        int price;
        Engine engine;

       public CarConstr(int modelno,string name,int price,Engine engine)
        {
            this.modelno = modelno;
            this.name = name;
            this.price = price;
            this.engine = engine;
        }

        void display()
        {
            Console.Write(modelno + " " + name + " " + price);
            engine.show();

        }
        static void Main(string[]args)
        {
            CarConstr cc = new CarConstr(101,"bmw",87878,new Engine("petrol"));
            cc.display();
        }
    }
}
