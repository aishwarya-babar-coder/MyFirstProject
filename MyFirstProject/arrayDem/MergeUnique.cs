using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class MergeUnique
    {
       public void UMerge(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[arr1.Length + arr2.Length];

            int j = 0;
            for(int i=0;i<arr1.Length;i++)
            {
                arr3[j] = arr1[i];
                j++;
            }
            for(int i=0;i<arr2.Length;i++)
            {
                bool ispresent = false;
                for(int k=j-1;k>=0;k--)
                {
                    if(arr3[k]==arr2[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {

                    arr3[j] = arr2[i];
                    j++;
                }
            }

            for(int i=0;i<arr3.Length;i++)
            {

                Console.WriteLine(arr3[i]);
            }
        }
        static void Main(string[]args)
        {
            int[] a = new int[5];
            int[] b = new int[7];
            Console.WriteLine("enter elements for first array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter elements for second array");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }
            MergeUnique m = new MergeUnique();
            m.UMerge(a, b);
           
        }
    }

}
