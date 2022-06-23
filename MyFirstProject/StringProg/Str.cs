using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.StringProg
{
    class Str
    {
        static void Main(string[] args)
        {
            string[] s = { "A+2", "B+7", "D+3", "E+8" };

            Console.WriteLine(string.Join(" ", s));

            Console.WriteLine("enter a char");
            char ch = Console.ReadLine()[0];

            for (int i = 0; i <s.Length; i++)
            {
                string[] s1 = s[i].Split("+");
                
                    char[]ch1=s[i].ToCharArray();
                    for(int j=0;j<ch1.Length;j++)
                    {
                   
                    if(ch1[j].Equals(ch))
                    {
                        ch1[j] = ch1[j + 2];
                        Console.WriteLine(ch1[j]);
                    }
            }
                
            }
        }
    }

}
            
            

            
            
            
        
    

