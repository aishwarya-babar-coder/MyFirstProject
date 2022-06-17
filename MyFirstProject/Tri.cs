using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject
{
    class Tri
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter a no");
            int n = int.Parse(Console.ReadLine());

            int ori = n;

            int cube = n * n * n;

            int cu = cube;

            Console.WriteLine(cube);

            int countOrig = 0;
            int countCube = 0;

            while (n > 0)
            {
                countOrig++;
                n = n / 10;
            }
            Console.WriteLine("orig count " + countOrig);

            while (cube > 0)
            {
                countCube++;
                cube = cube / 10;
            }

            Console.WriteLine("cube count " + countCube);

            int power = 1;
            for (int i = 1; i < countCube; i++)
            {
                power = power * 10;
            }
            Console.WriteLine("power is " + power);

            int rem = cu % power;
            Console.WriteLine("remainder is " + rem);

            int countRem=0;
  
            Console.WriteLine(countRem);

            if(countRem==countOrig)
            {
                if (rem == ori)
                {

                    Console.WriteLine("tri");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                while (power > 0)
                {
                    rem=cu % power;
                    power--;
                    Console.WriteLine("power is "+power);
                    countRem++;
                    Console.WriteLine("count of rem is " + countRem);
                    rem = rem / 10;
                }

            }

            
        }
    }
}
