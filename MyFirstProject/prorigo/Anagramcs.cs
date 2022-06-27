using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.prorigo
{
    class Anagramcs
    {
        public static bool check(string s1,string s2)
        {
            if(s1.Length==s2.Length)
            {
                string s3 = s1.ToLower();
                string s4 = s2.ToLower();

                char[] ch1 = s3.ToCharArray();
                char[] ch2 = s4.ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                string s5 = new string(ch1);
                string s6 = new string(ch2);

                if(s5==s6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        static void Main(string[]args)
        {
            Console.WriteLine("enter first string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter first string");
            string str2 = Console.ReadLine();


            bool b = Anagramcs.check(str1, str2);

            if(b==true)
            {
                Console.WriteLine("anagram");
            }
            else
            {
                Console.WriteLine("no anagram");
            }
        }
    }
}
