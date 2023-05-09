using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public void addDigitsOfNumber()
        {
            int n;
            int a;
            int sum = 0;
            Console.WriteLine("Enter a number");
            n=int.Parse(Console.ReadLine());
            while (n > 0)
            {
                a = n % 10;
                n = n / 10;
                sum = sum + a;
                
            }
            Console.WriteLine("Sum=" + sum);

        }
        public static void Main(string[] args)
        {
            var obj= new Program();
            obj.addDigitsOfNumber();
        }
        
    }
}