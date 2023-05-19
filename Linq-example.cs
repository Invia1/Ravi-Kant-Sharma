using System;
using System.Linq;

class IntroToLINQ
{
    static void Main()
    {
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
        var numQuery =
            from num in numbers
            where (num % 2) == 0
            select num;
        foreach (int number in numQuery)
        {
            Console.Write("{0,1} ", number);
        }
    }
}