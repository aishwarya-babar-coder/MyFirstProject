using System;
using System.Collections.Generic;
using System.Text;

//using namespace to acees from another project
namespace MyFirstProject.oops
{
    public class AccessModifier //class should be public to access from another project //parent
    {
        //by default access modifier is internal or private
        private int x = 10;//acccess within same class
        public int y = 300;
        protected int z = 45; //access can access from another class using inheritance relationship
        static void Main(string[] args)
        {
            AccessModifier a = new AccessModifier();
            Console.WriteLine(a.x);//private member can acccess in same class
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);
        }
    }

    class ModifiersDemo:AccessModifier //inheritance so child
    {
        static void Main(string[]args)
        {
            AccessModifier a = new AccessModifier();
            //Console.WriteLine(a.x); private cant access outside of the class
            Console.WriteLine(a.y);

            ModifiersDemo m = new ModifiersDemo();
            Console.WriteLine(m.z);

        }
    }

}
