using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class EvenOddCount
    {
        public void Count(int []arr)
        {
            int count1 = 0;
            int count2 = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    count1++;
                }
                else
                {
                    count2++;
                }
            }
            Console.WriteLine("even elements are "+count1);
            Console.WriteLine("odd elements are " +count2);
        }
        
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            EvenOddCount e1 = new EvenOddCount();
            e1.Count(a);
            
        }
    }
}
