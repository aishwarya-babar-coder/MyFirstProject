using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.oops
{
    class Shopping
    {
        int qty;
        double price;
        string item;
        double bill;
        double Total;
       public Shopping(int Sqty,double Sprice,string Sitem)
        {
            qty = Sqty;
            price = Sprice;
            item = Sitem;
        }

       public void  GetBill()
        {
            
            if(qty>0)
            {
                bill = qty * price;

                this.show(bill);
            }
            else
            {
                Console.WriteLine("error");
      
            }
            
        }

        public void show(double Bill)
        {
            Console.WriteLine("bill of item " + item + " with quantity = " + qty + " and  price = " + price + " is " + bill);
        }

        static void Main(string[]args)
        {
            Shopping s1 = new Shopping(5,20,"pen");
            Shopping s2 = new Shopping(2, 10, "pencils");
            Shopping s3 = new Shopping(0, 5, "eraser");

            s1.GetBill();
            s2.GetBill();
            s3.GetBill();

            

        }
    }
}
