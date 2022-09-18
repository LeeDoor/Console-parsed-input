using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_parsed_input
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter int: ");
            int a = ConsoleReader.ReadInt(n => n > 10 && n < 20);
            Console.WriteLine($"{a} value");
        }
    }
}
