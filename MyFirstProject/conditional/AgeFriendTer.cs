using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class AgeFriendTer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int your = int.Parse(Console.ReadLine());

            Console.WriteLine("enter friend's age");
            int friend = int.Parse(Console.ReadLine());


            string age = friend > your ? "good morning" : friend < your ? "hi" : "how are you";

            Console.WriteLine(age);
            }
        }
    }

