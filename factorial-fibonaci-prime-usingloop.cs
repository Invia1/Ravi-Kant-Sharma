using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    internal class Program
    {
        static void Factorial(int x, int sum)
        {

            for (int i = 1; i <= x; i++)
            {
                sum = sum * i;

            }
            Console.WriteLine("Factorial of the number is " + sum);
        }

        static void Fabonaciseries(int n)
        {
            int n1 = 0; int n2 = 1;
            int sum = 0;
            Console.WriteLine("Fabonici series is ..");
            Console.Write(n1 + " " + n2);

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                Console.Write(" " + sum);
                n1 = n2;
                n2 = sum;

            }
            Console.WriteLine();
        }

        static void PrimeNumber(int n)
        {
            int count = 0;
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("It is not a prime number");
            }
            else
            {
                Console.WriteLine("It is a Prime Number");
            }
        }
        static void function()
        {
            Console.WriteLine("Enter your choice ");
            Console.WriteLine("****************************************************** ");
            Console.WriteLine("Enter 1 for Factorial Number  ");
            Console.WriteLine("Enter 2 for Fabonaci Series  ");
            Console.WriteLine("Enter 3 for Prime Number   ");
            Console.WriteLine("*******************************************************");
            int choice = int.Parse(Console.ReadLine());

            int number, sum = 1;
            Console.WriteLine("Enter a Number");
            number = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Factorial(number, sum);
                    break;
                case 2:
                    Fabonaciseries(number);
                    break;
                case 3:
                    PrimeNumber(number);
                    break;

                default:
                    Console.WriteLine("Enter valid choice");
                    break;


            }
        }


        static void Main(string[] args)
        {
            char n;
            bool ch = true;

            while (ch)
            {
                function();
                Console.WriteLine("Do you want to continue, Enter Y for Continue");
                n = char.Parse(Console.ReadLine());
                if (n != 'y' && n != 'Y')
                {
                    ch = false;
                }
            }

        }
    }
}

