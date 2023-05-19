using System;
using System.Linq;
using System.Collections;

class IntroToLINQ
{
    static void Main()
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Name", "Ravi");
        hashtable.Add("Address", "Delhi");
        hashtable.Add("Id", 1234);

        Console.WriteLine("Name= " + hashtable["Name"]);
        Console.WriteLine("Address= " + hashtable["Address"]);
        Console.WriteLine("Id= " + hashtable["Id"]);
    }
}
