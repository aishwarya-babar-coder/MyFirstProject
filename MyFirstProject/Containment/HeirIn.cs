using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    interface IMobile
    {
        void Mob();
    }
    interface ISamsung:IMobile
    {
        public static void Mob()
        {
            Console.WriteLine("samsung mobile");
        }
    }
    interface IApple:IMobile
    {
        public static void Mob()
        {
            Console.WriteLine("apple mobile");
        }
    }
    interface INokia:IMobile
    {
        public static void Mob()
        {
            Console.WriteLine("nokia mobile");
        }
    }
    class HeirIn//:INokia,ISamsung,IApple
    {
        //public void Mob()
        //{
           // Console.WriteLine("My mobile");
       // }
        static void Main(string[]args)
        {
           // HeirIn h = new HeirIn();
         //   h.Mob();
            INokia.Mob();
            ISamsung.Mob();
            IApple.Mob();


        }
    }
}
