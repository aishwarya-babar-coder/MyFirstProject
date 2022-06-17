using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.conditional
{
    class AgeFriend
    {
        static void Main(string[]args)
        {
            Console.WriteLine("enter your age");
            int your = int.Parse(Console.ReadLine());

            Console.WriteLine("enter friend's age");
            int friend = int.Parse(Console.ReadLine());

            if(friend>your)
            {
                Console.WriteLine("good morning");
            }
            else if(friend<your)
            {
                Console.WriteLine("hi");
            }
            else
            {
                Console.WriteLine("how wre you");
            }
        }
    }
}
