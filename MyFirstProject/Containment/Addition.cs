using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Containment
{
    public interface Ifirstable
    {
        static int a = 100;
    }
    abstract class second
    {
        public static int b=30;
    }

    class add:second,Ifirstable
    {
        
        public void addn()
        {
            Console.WriteLine("addition is " + (Ifirstable.a + second.b));
        }
    }
    class Addition
    {
        static void Main(string[]args)
        {
            add a = new add();
            a.addn();
        }
    }
}
