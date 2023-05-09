using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    internal class Person
    {
        int amount;
         print obj= new print();

        public int Amount
        {
            get 
            { 
                return amount;
            } 
            set
            {
                amount = value;
                if (amount<10000)
                {
                    obj.noAmount();
                }
                else
                {
                    obj.amount();
                }
                
            }
        }
    }

    internal class print
    {
        public void amount()
        {
            Console.WriteLine("Your amount is above 10000 . You can do Shopping.");
        }
        public void noAmount()
        {
            Console.WriteLine("Your amount is below 10000 . You can't do Shopping.");
        }

    }
    class shopping
    {

        static void Main()
        {
          Person obj = new Person();
            Console.WriteLine("Enter Your amount for Shopping ");
            obj.Amount=int.Parse(  Console.ReadLine());

        }
    }
}