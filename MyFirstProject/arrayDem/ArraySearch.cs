using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.arrayDem
{
    class ArraySearch
    {
        static void Main(string[]args)
        {
            int[] a = { 5, 7, 1, 9 };
            Console.WriteLine("enter element to search");
            int num = int.Parse(Console.ReadLine());

            bool ispresent = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == num)
                {
                    ispresent = true;
                    break;
                }
            }

            if(ispresent==true)
                {
                    Console.WriteLine("element found");
            
                }
            else
            {
                Console.WriteLine("element not found");
            }
            }
        

        
    }
}
