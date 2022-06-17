using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.basics
{
    class DataTypes
    {
        static void Main(string[]args)
        {
            byte mybyte = 12; //1 bytes=8bits, 127 to -128
            sbyte mybyte2 = -5;//7bits to store value and 1 bit for sign storage

            Console.WriteLine(mybyte + " " + mybyte2);

            ushort myshort = 457;//2 bytes=16 bits, 32768 to -32767
            short myshort2 = -799;

            Console.WriteLine(myshort + " " + myshort2);

            int m1 = 67888;  //4 bytes=32 bits, 2^32 to 2^-32 
            int m2 = -89769;

            Console.WriteLine(m1 + " " + m2);

            ulong l = 9878990087666545L;  //8 bytes=64 bits,  2^64 to 2^-64

            Console.WriteLine(l);

            double per = 67.89; //8 bytes
            Console.WriteLine(per);

            float ft = 89.67f; //4 bytes
            Console.WriteLine(ft);

            char ch = 'a';
            Console.WriteLine(ch);

            bool isbool = true;
            Console.WriteLine(isbool);

            string name = "aish";
            Console.WriteLine(name);

        }
    }
}
