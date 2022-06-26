using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class Min
    {
        static void Main(string[]args)
        {

            int[] a = new int[5];
            Console.WriteLine("enter elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[i] == a[k])
                    {
                        isvisited = true;
                        break;
                    }
                }

                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                    else if (count > 1)
                    {
                        Console.WriteLine(a[i] + " " + count);
                    }
                }


            }

            
        }
    }
}
