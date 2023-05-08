using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int number,sum=1;
            Console.WriteLine("Enter a Number");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <=number; i++)
            {
                sum = sum * i;
                
            }
            Console.WriteLine("Factorial of the number is " + sum);
        }
    }
}