using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class Swapping
    {
        public void swap(ref int x,ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[]args)
        {
            Console.WriteLine("enter first no");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter second no");
            int n2 = int.Parse(Console.ReadLine());

            Swapping s1 = new Swapping();

            Console.WriteLine("before swapping");
            Console.WriteLine(n1+" "+n2);

            Console.WriteLine("after swapping");
            s1.swap(ref n1, ref n2);
            Console.WriteLine(n1 + " " + n2);



        }
    }
}
