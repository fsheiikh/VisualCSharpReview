using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double saleAmount;
            char code;
            DiscountDelegate firstDel, secondDel, thirdDel;

            firstDel = new DiscountDelegate(StandardDiscount);
            secondDel = new DiscountDelegate(PreferredDiscount);

            thirdDel = firstDel;
            thirdDel += secondDel;
    
            Console.WriteLine("Enter amount of sale ");
            saleAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter S for standard dsicount, or P for Preferred Discount, X for extreme");
            code = Convert.ToChar(Console.ReadLine());

            if (code == 'S')
                firstDel(ref saleAmount);
            else if (code == 'P')
                secondDel(ref saleAmount);
            else
                thirdDel(ref saleAmount); //runs the saleAmount variable through both the standard and preferred discount methods



            Console.WriteLine("New sale amount is {0}", saleAmount.ToString("C2"));

            Console.ReadKey();
        }

        delegate void DiscountDelegate(ref double saleAmount);

        //Begin creating a Discount class that contains a StandardDiscount() method.
        //The method accepts a reference parameter that represents an amount of a sale.
        //If the sale amount is at least $1,000, a discount of 5 percent is calculated and subtracted 
        //from the sale amount.If the sale amount is not at least $1,000, nothing is subtracted. 
        public static void StandardDiscount(ref double saleAmount)
        {
            const double DISCOUNT_RATE = 0.05;
            const double CUTOFF = 1000.00;
            double discount;

            discount = (saleAmount >= CUTOFF) ? (saleAmount * DISCOUNT_RATE) : (discount = 0);
            //if sale is >= to cutoff price, get discount % from price minus rate, else, no discount

            saleAmount -= discount;
        }
        //Add a PreferredDiscount() method.The method also accepts a reference parameter that represents 
        //the amount of a sale and calculates a discount of 10 percent on every sale.
        public static void PreferredDiscount(ref double saleAmount)
        {
            const double SPECIAL_DISCOUNT = 0.10;
            double discount = saleAmount * SPECIAL_DISCOUNT; //discount is given regardless of saleAmount
            saleAmount -= discount;
        }

    }

    class DiscountDelegateDemo
    {
       

    }
}
