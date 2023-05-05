using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable
{
    internal class Program
    {
        static readonly int id;
        Program()
        {
            id = 1001;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
           Console.WriteLine(Program.id);
        }
    }
}
