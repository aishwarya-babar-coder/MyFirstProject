using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class OddPos
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("display elements at odd positions");

            for (int i = 0; i < a.Length; i = i + 2)
            {
                Console.WriteLine(a[i]);
            }
}
    }

}
