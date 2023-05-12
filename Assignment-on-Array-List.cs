using System;
using System.Collections;

namespace Day_6_Assignment2
{
    internal class DataEntryContact
    {
        ArrayList obj = new ArrayList();
        public void AddData()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Name List");
            Console.WriteLine("---------------------------------------------------------------");
            obj.Add("Ravi");
            obj.Add("Saksham");
            obj.Add("Mannu");
            obj.Add("Pankaj");
            obj.Add("Ankit");
            obj.Add("Pushpendra");

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
        public void RemoveData()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Enter Data which you want to remove.");
            Console.WriteLine("---------------------------------------------------------------");
            obj.Remove(Console.ReadLine());

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Data after remove");
            Console.WriteLine();    

            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchData()
        {
            Boolean flag;
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Enter the name you want to search ");
            Console.WriteLine("---------------------------------------------------------------");
            string name = Console.ReadLine();
            flag = obj.Contains(name);
            if (flag==true)
            {
                Console.WriteLine(name+" is present in the list");
            }
            else
            {
                Console.WriteLine(name+" is not present in the list");
            }  

        }
        public void UpdateData()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Enter Name you want to Update");
            obj.Add(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Name list after update");
            Console.WriteLine();
            foreach(var item in obj)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main()
        {
            DataEntryContact contact = new DataEntryContact();
            contact.AddData();

            contact.RemoveData();

            contact.SearchData();

            contact.UpdateData();

            Console.WriteLine();
        }
    }
}
