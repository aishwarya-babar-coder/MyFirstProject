using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class MergeUnique
    {
        public void UMerge(int[] arr1, int[] arr2)
        {

            int size1 = arr1.Length;
            int size2 = arr2.Length;
            int size3 = size1 + size2;
            int[] arr3 = new int[size3];
           
            for (int i=0;i<size1;i++)
            {
                for (int j = i + 1; j < size1; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        for (int k = j; k < size1 - 1; k++)
                        {
                            arr1[k] = arr1[k + 1];
                        }
                        size1--;
                        j--;
                    }
                }
            }
            for (int m = 0; m < size1; m++)
            {
                arr3[m] = arr1[m];
            }

            for (int i = 0; i < size2; i++)
            {
                for (int j = i + 1; j < size2; j++)
                {
                    if (arr2[i] == arr2[j])
                    {
                        for (int k = j; k < size2 - 1; k++)
                        {
                            arr2[k] = arr2[k + 1];
                        }
                        size2--;
                        j--;
                    }
                }
            }
            for(int i=0;i<size1;i++)
            {
                for(int j=0;j<size2;j++)
                {
                    if(arr1[i]==arr2[j])
                    {
                        for(int k=j;k<size2-1;k++)
                        {
                            arr2[k] = arr2[k + 1];
                        }
                        size2--;
                        j--;
                    }
                }
            }
            for (int m=0;m<size2;m++)
            {
                arr3[size1 + m] = arr2[m];
            }

            size3 = size1 + size2;
            for(int i=0;i<size3;i++)
            {
                Console.Write(arr3[i] + "  ");                
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
