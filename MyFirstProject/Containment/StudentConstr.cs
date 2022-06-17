using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    class Placed
    {
        bool isplaced;

        public Placed(bool isplaced)
        {
            this.isplaced = isplaced;

        }

        public void show()
        {
            Console.WriteLine(" " + isplaced);
        }
    }

    class StudentConstr
    {
        int id;
        string name;
        float perc;
        Placed isplaced;

        public StudentConstr(int id,string name,float perc,Placed isplaced)
        {
            this.id = id;
            this.name = name;
            this.perc = perc;
            this.isplaced = isplaced;
        }

        public void display()
        {
            Console.Write(id + " " + name + " " + perc);
            isplaced.show();
        }
        static void Main(string[]args)
        {
            StudentConstr s = new StudentConstr(101,"ash",7865f,new Placed(true));
            s.display();

        }
    }

}
