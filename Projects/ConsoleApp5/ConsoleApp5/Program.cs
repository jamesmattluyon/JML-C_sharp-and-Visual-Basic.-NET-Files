using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal n1 = new Animal();
            Console.ForegroundColor = ConsoleColor.Green;
            n1.Model = "Dog";
            n1.Sound = "Aw aw";
            Console.WriteLine($"{n1.Model} sounds {n1.Sound}, as of {DateTime.Now.ToShortDateString()}");
                

            Console.ReadLine();
        }
    }
}
