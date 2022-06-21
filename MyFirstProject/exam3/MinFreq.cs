using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class MinFreq
    {
        public void freq(char[]arr)
        {
            char min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("minimum frequency is " + min);
        }
        static void Main(string[]args)
        {
            char[] a = new char[6];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Console.ReadLine()[0];
            }

            MinFreq m1 = new MinFreq();
            m1.freq(a);
        }
    }
}
