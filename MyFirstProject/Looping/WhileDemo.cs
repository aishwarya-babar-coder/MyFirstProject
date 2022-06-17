using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Looping
{
    class WhileDemo
    {
        //magic number
        static void Main(string[] args)
        {
            int magic = 67;

            while(true)
            {
                Console.WriteLine("enter a number");
                int num = int.Parse(Console.ReadLine());

                if (num < magic)
                {
                    Console.WriteLine("number is less than magic number plz try again");
                    continue;
                }
                else if (num > magic)
                {
                    Console.WriteLine("number is greater than magic number plz try again");
                    continue;
                }
                else
                {
                    Console.WriteLine("congratulations!!number is match");
                    break;
                }
            }
        }
    
    }

    class WhileDemo2
    {
        //even odd
        static void Main(string[]args)
        {
            int i = 1;
            while(i<=10)
            {
                if(i%2==0)
                {
                    Console.WriteLine("number is even so "+i);
                }
                else
                {
                    Console.WriteLine("number is odd so "+(i * i));
                }
                i++;
            }
        }
    }

    class WhileDemo3
    {
        //armstrong
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int n = int.Parse(Console.ReadLine());

            int temp = n;
            int count = 0;
            int digit = 0;
            int sum = 0;

            while (temp > 0)
            {
                temp = temp / 10;
                count++;//count digits
            }

            temp = n;
            while (temp > 0)
            {
                digit = temp % 10; //to find out digits

                sum = sum + (int)(Math.Pow(digit, count));

                temp = temp / 10;
            }
            if (n == sum)
            {
                Console.WriteLine("number is Armstrong number");
            }
            else
            {
                Console.WriteLine("no armstrong");
            }

        }
    }

    class WhileDemo4
    {
        //series :2 5 10 17 26

        /*
         logic 
            1*1+1=2;
            2*2+1=5;
            3*3+1=10;
            4*4+1=15
            5*5+1=26
          
         */
        static void Main(string[]args)
        {
            int next, i = 1, range = 5;

            while(i<=range)
            {
                next = i * i + 1;
                Console.WriteLine(next+ " ");
                i++;

            }
        }
    }

   /* class WhileDemo5
    {
        static void Main(string[]args)
        {
            int range = 4;

            int i = 1;

            while(i<=range)
            {
                
            }
        }
    }*/

    class WhileDemo6
    {
        //spy no= sum of digits = cube of digits
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            int prod = 1;
            while (num>0)
            {
                int digit=num % 10; //to find out digit

                sum = sum + digit;

                prod = prod * digit;

                num = num / 10;

            }

            if(sum==prod)
            {
                Console.WriteLine("spy");
            }
            else
            {
                Console.WriteLine("not spy");
            }
        }
    }

    class WhileDemo7
    {
        static void Main(string[]args)
        {
            //series :2,12,36,80
            //logic : (i*i)+(i*i*i)

            int i = 1;
            int range = 4;
            int next;
            while(i<=range)
            {
                next = (i * i) + (i * i * i);
                Console.WriteLine(next);
                i++;
            }
        }
    }

    class WhileDemo8
    {
        static void Main(string[]args)
        {
            //series 0,3,8,15,24
            //logic:(i*i)-1

            int i = 1;

            int range = 4;

            int next;
            while(i<=range)
            {
                next = (i * i) - 1;
                Console.WriteLine(next);
                i++;
            }
        }
    }

    class WhileDemo9
    {
        static void Main(string[]args)
        {
            //palindorme
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int temp = num;

            int rev = 0;

            
            while(temp>0)
            {
                int digit = temp % 10;
                rev = rev *10 + digit;
                temp = temp / 10;
            }

            if(num==rev)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("no palindrome");
            }
        }
    }

    class WhileDemo10
    { //decimal to binary
        static void Main(string[]args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

              int rem = 0;
              String binary = "";
              while (num > 0)
              {
                  rem = num % 2;
                  binary = rem + binary;
                  num = num / 2;
              }
              Console.WriteLine(binary);
            
            

        }
    }

    class WhileDemoA
    {
        static void Main(string[] args)
        {
            //binary to decimal

            Console.WriteLine("enter the no");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int p = 0;
            while (num > 0)
            {
                int r = num % 10; // last digit seperate

                int power = (int)(Math.Pow(2, p));

                sum = sum + (power * r);

                num = num / 10;

                p++;

            }

            Console.WriteLine(sum);
        }
    }

        class WhileDemoB
        { //sum of digits
            static void Main(string[] args)
            {
                Console.WriteLine("enter a number");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum = sum + digit;
                    num = num / 10;
                }

                Console.WriteLine("sum of dogit of given number is " + sum);
            }
        }

    class WhileDemoC
    {
        //reverse number
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            int rev = 0;
            while(num>0)
            {
                int digit = num % 10; //last digit

                rev = rev * 10 + digit;

                num = num / 10;
            }
            Console.WriteLine("reverse number is " + rev);
        }
}

    class WhileDemoD
    {
        static void Main(string[]args)
        {
            //print i to 10
            int i = 1;
            while(i<=5)
            {
                Console.WriteLine(i); //1 2 3 4 5
                i++;
            }
        }
    }

    class WhileDemoE
    {
        static void Main(string[] args)
        {
            
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i); //10 to 1
                i--;
            }
        }
    }

    class WhileDemoF
    {
        static void Main(string[] args)
        {
            
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine(i); //infinite
                i--;
            }
        }
    }

    class WhileDemoG
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("hi"); //infinite
                
            }
        }
    }

    class DoWhileDemo1
    {
        static void Main(string[] args)
        {
            //print 1 to 10
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <=10); //1to10
            
         
        }
    }

    class DoWhileDemo2
    {
        static void Main(string[] args)
        {
            
            int i = 1;
            do
            {
                Console.WriteLine(i); //1
                i++;
            }
            while (i >10);


        }
    }

    class DoWhileDemo3
    {
        //menu driven program
        static void Main(string[] args)
        {
            //print 1 to 10
            Console.WriteLine("enter num1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter num2");
            int num2 = int.Parse(Console.ReadLine());

            char ch;
            do
            {
                Console.WriteLine("1.Add \n2.subtract \n3.mult \n4.div \n5.rem");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("addition is " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("addition is " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("addition is " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("addition is " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("addition is " + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("invalid choice ");
                        break;
                }

                Console.WriteLine("do you want to continue? \npress y OR Y to continue");
                 ch = Console.ReadLine()[0];

            }
            while (ch == 'y' || ch == 'Y');

        }
    }

}
