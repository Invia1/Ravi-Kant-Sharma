using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Services;

class contactList
{
    List<string> obj = new List<string>();
    public void AddData()
    {
        Console.WriteLine("Enter Number of elements you want to Add..");
        
        int n =int.Parse(Console.ReadLine());
        Console.WriteLine("----------------------------------------------");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Elements : ");
            obj.Add(Console.ReadLine());
        }

    }
    public void RemoveData()
    {
        Console.WriteLine("Enter the name you want to remove..");

        obj.Remove(Console.ReadLine());
        Console.WriteLine("List After Remove:-");
        foreach (var item in obj)
        {
            Console.WriteLine(item);
        }
    }
    public void SearchData()
    {
        bool flag;
        Console.WriteLine("Enter the name you want to search.");
        flag= obj.Contains(Console.ReadLine());
        if (flag==true)
        {
            Console.WriteLine("This name is Present in the list.");
        }
        else
        {
            Console.WriteLine("This name is not Present in the list.");
        }
    }
    public void ClearData()
    {
        obj.Clear();
        foreach (var item in obj)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("List is Cleared.");
    }
    public void UpdateData()
    {
        Console.WriteLine("Enter name you want to Update.");
        string name = Console.ReadLine();
        Console.WriteLine("Enter name you want to Replace with new name.");
        string oldname = Console.ReadLine();

        for (int i = 0;i<obj.Count;i++)
        {
            if (obj[i].Equals(oldname))
            {
                obj[i] = name;
                Console.WriteLine("Name is Updated Successful...");
                break;
            }
        }
        Console.WriteLine("List after Update:-");
        foreach (var item in obj)
        {
            
            Console.WriteLine(item);
        }
    }
    public void PrintData()
    {
        if (obj.Count == 0)
        {
            Console.WriteLine("List is Empty.");
        }
        else
        {
            
            Console.WriteLine("Data of the list is:- ");
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }

    }
}
class contact
{
    public static void Main()
    {
        contactList obj = new contactList();
        bool flag=true;
        while (flag)
        {



            int n;
            Console.WriteLine("Enter 1 For Add Data..");
            Console.WriteLine("Enter 2 For Remove Data..");
            Console.WriteLine("Enter 3 For Search Data..");
            Console.WriteLine("Enter 4 For Clear Data..");
            Console.WriteLine("Enter 5 For Update Data..");
            Console.WriteLine("Enter 6 For Print Data..");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter your choice.");
            n = int.Parse(Console.ReadLine());



            switch (n)
            {
                case 1:
                    obj.AddData();
                    break;
                case 2:
                    obj.RemoveData();
                    break;
                case 3:
                    obj.SearchData();
                    break;
                case 4:
                    obj.ClearData();
                    break;
                case 5:
                    obj.UpdateData();
                    break;
                case 6:
                    obj.PrintData();
                    break;
                default:
                    Console.WriteLine("Enter valid number ");
                    break;

            }
            Console.WriteLine("Do you want to continue ? If yes press 'Y'. Otherwise press 'N'.");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'Y' || ch == 'y')
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
        }
    }
}