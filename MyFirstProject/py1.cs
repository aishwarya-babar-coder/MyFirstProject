﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class py1
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                
                Console.WriteLine();

            }
        }
    }
}
