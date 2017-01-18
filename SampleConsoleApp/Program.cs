using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("Costas", "Petrou", 1000);
            Console.WriteLine("Welcome to this app! Press any key to close");
            Console.WriteLine(c.ToString());
            Console.ReadLine();

        }
    }
}
