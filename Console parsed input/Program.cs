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
            Console.WriteLine("enter int, where 10 < int < 20: ");
            int a = ConsoleReader.ReadInt(n => n > 10 && n < 20);
            Console.WriteLine($"{a} value");

            Console.WriteLine("enter string where 10 < string's length < 30: ");
            string b = ConsoleReader.ReadString(n => n.Length > 10 && n.Length < 30);
            Console.WriteLine($"{b} string with {b.Length} length");
        }
    }
}
