using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringToInt;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 'e' to escape");
            Console.WriteLine("Input string for convertion to int");
            string str = String.Empty;
            while (!str.Equals("e", StringComparison.OrdinalIgnoreCase))
            {
                str = Console.ReadLine();
                if (str.Equals("e", StringComparison.OrdinalIgnoreCase))
                    continue;

                try
                {
                    Console.WriteLine($"Converted to int: {str.ToInt()}");
                }
                catch (ValidationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
