﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class FreqAll
    {
        public void freq(int[]arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1;k>=0;k--)
                {
                    if(arr[i]==arr[k])
                    {
                        isvisited = true;
                        break;
                    }
                }

                if(isvisited==false)
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        if(arr[i]==arr[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(arr[i] + " " + count);
                    }
                    else if(count>1)
                    {
                        Console.WriteLine(arr[i] + " " + count);
                    }
                }
            }
        }
        static void Main(string[]args)
        {
            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            FreqAll f = new FreqAll();
            f.freq(a);
        }
            

    }
}
