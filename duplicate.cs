using System;


namespace Duplicate
{
    internal class Program
    {
       
        static void Duplicate(char[] list)
        {
            int count = 0;
            bool[] visited = new bool[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                if (visited[i]==true)
                {
                    continue;
                }
                for (int j = 0; j < list.Length; j++)
                {
                    if (list[i] == list[j]) 
                    {
                        visited[j] = true;
                        count++;
                    }
                }
                if (list[i]!=' ')
                {
                    Console.WriteLine(list[i] + " repeats "+count);
                    count= 0;
                    
                }
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string");
            string name=Console.ReadLine();
            name=name.ToLower();
            char[] name1=name.ToCharArray();
           
            Duplicate(name1);

            
        }
    }
}
