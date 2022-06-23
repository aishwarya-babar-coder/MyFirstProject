using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.exam3
{
    class MinFreq
    {
        static int leastFrequent(int[] arr, int n)
        {
            // Sort the array
            Array.Sort(arr);

            // find the min frequency
            // using linear traversal
            int min_count = n + 1, res = -1;
            int curr_count = 1;

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                    curr_count++;
                else
                {
                    if (curr_count < min_count)
                    {
                        min_count = curr_count;
                        res = arr[i - 1];
                    }

                    curr_count = 1;
                }
            }

            // If last element is least frequent
            if (curr_count < min_count)
            {
                min_count = curr_count;
                res = arr[n - 1];
            }

            return res;
        }
        static void Main(string[]args)
        {

            int[] arr = { 1, 3, 2, 1, 2, 2, 3, 1 };
            int n = arr.Length;

            // Function calling
            Console.Write(leastFrequent(arr, n));
        }
    }
}
