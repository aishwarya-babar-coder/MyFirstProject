using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject._2darray
{
    class Addition
    {
        static void Main(string[]args)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] add = new int[3,3];
            int i;
            int j;
            Console.WriteLine("enter elements for first array");
            for ( i = 0; i < a.GetLength(0); i++)
            {
                for ( j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("first array is");
            for (i = 0; i < a.GetLength(0); i++)
            {

                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("enter elements for second elements");
            for ( i = 0; i < b.GetLength(0); i++)
            {
                for ( j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("second array is");
            for (i = 0; i < b.GetLength(0); i++)
            {

                for (j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write(b[i, j]+" ");
                }
                Console.WriteLine();
            }


            for ( i = 0; i < add.GetLength(0); i++)
            {
              
                for ( j = 0; j < add.GetLength(1); j++)
                {
                    add[i,j] = a[i,j]+b[i,j];
                }
            }

            Console.WriteLine("addition of first array and second array is");
            for (i = 0; i < add.GetLength(0); i++)
            {

                for (j = 0; j < add.GetLength(1); j++)
                {
                    Console.Write(add[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
