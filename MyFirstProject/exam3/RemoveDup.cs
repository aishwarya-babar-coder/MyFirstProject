using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class RemoveDup
    {
        
         static void Main(String[] args)
        {
            int[] arr = new int[7];
            int size = arr.Length;
            for(int i=0;i<size;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i=0;i<size;i++)
            {
                for(int j=i+1;j<size;j++)
                {
                    if(arr[i]==arr[j])
                    {
                        for(int k=j;k<size-1;k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        size--;
                        j--;
                    }
                }
            }

            for(int i=0;i<size;i++)
            {
                Console.WriteLine(arr[i]+"  ");
            }
        }
    }
}
