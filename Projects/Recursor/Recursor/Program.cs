using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            try
            {
                int num = Convert.ToInt32(input);
                if(num > 1)
                {
                    var total = SumofProducts(num);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"The sum of product: {num} is {total}");

                }
                Console.ReadLine();
            }
            
            catch(FormatException)
            {
                Console.WriteLine("Invalid numeric");
            }

            int SumofProducts(int x)
            {
                if (x > 1)
                    return x * (x - 1) + SumofProducts(x - 1);
                else
                    return 0;
            }
        }
    }
}
