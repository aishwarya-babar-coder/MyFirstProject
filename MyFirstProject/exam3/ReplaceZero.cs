using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    
    class ReplaceZero
    {
        public void replace(int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]==0)
                {
                    arr[i] = 1;
                }
            }

            Console.WriteLine("new array is ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };
            ReplaceZero r1 = new ReplaceZero();
            r1.replace(a);
        }
    }
}
