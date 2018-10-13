using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSymbolReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 'e' to escape");
            string str = String.Empty;
            while (!str.Equals("e", StringComparison.OrdinalIgnoreCase))
            {
                str = Console.ReadLine();

                try
                {
                    Console.WriteLine($"The first symbol: {str.GetFirstSymbol()}");
                }
                catch (ValidationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
