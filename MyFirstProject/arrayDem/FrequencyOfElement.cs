using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class FrequencyOfElement
    {
        public void freq(int[]arr)
        {
            Console.WriteLine("enter elements");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(n==arr[i])
                {
                    count++;
                }
            }
            Console.WriteLine("occurance of given no is " + count);
        }
        static void Main(string[]args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            FrequencyOfElement f = new FrequencyOfElement();
            f.freq(a);
        }
    }
}
