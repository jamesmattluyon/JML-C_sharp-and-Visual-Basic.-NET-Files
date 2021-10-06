using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
           
            string name, address;


            Console.Write("\n\n");
            Console.Write("\t        Sales Invoice: Details\n");
            Console.Write("\t----------------------------");
            Console.Write("\n\n");
            Console.Write("\tName of the customer: ");
            name = Console.ReadLine();
            Console.Write("\tAddress of the customer: ");
            address = Console.ReadLine();
            Console.Write("\tContact Number: ");
            long custid = long.Parse(Console.ReadLine());
            Console.Write("\tUnit Description: ");
            string description = Console.ReadLine();
            Console.Write("\tQuantity: ");
            long qty = long.Parse(Console.ReadLine());
            Console.Write("\tPrice of Product: ");
            long price = long.Parse(Console.ReadLine());
            Console.Write("\tCash Tendered: ");
            double ctend = double.Parse(Console.ReadLine());
            long amount = qty * price;
            double vsales = price * 0.12;
            double vat = vsales * 1.12;
            double change = ctend - amount;





            Console.WriteLine("\n\t==============================Luyon Computer System Corporation===============================");
            Console.WriteLine("\t                123456 Pag-Asang Makapagtapos Ave, BF Homes,  Parañaque City,                ");
            Console.WriteLine("\t                                    Sales Invoice                                            ");
            Console.WriteLine("\t                                                                                             ");
            Console.WriteLine($"\t    Sold to: {name}                                    Date: {DateTime.Now}            ");
            Console.WriteLine($"\t    Address: {address}                                 Contact Number: {custid}         ");
            Console.WriteLine($"\t===============================================================================================");
            Console.WriteLine($"\t     Qty    |              Unit Description                |      Price       |     Amount   ");
            Console.WriteLine($"\t===============================================================================================");
            Console.WriteLine($"\t     {qty}        {description}                                  {price}            {amount}  ");
            Console.WriteLine($"\t                                                                                              ");
            Console.WriteLine($"\t                                                                                              ");
            Console.WriteLine($"\t                                                                                              ");
            Console.WriteLine($"\t                                                                                              ");
            Console.WriteLine($"\t===============================================================================================");
            Console.WriteLine($"\t===============================================================================================");
            Console.WriteLine($"\t                                                            Total Amount Due: | {amount}      ");
            Console.WriteLine($"\t===============================================================================================");
            Console.WriteLine($"\t                                                            Vatable Sales:    | {vsales}      ");
            Console.WriteLine($"\t                                                                      Vat:    | {vat}         ");
            Console.WriteLine($"\t                                                            Cash Tendered:    | {ctend}       ");
            Console.WriteLine($"\t                                                                   Change:    | {change}      ");
            Console.WriteLine($"\t===============================================================================================");
            Console.WriteLine($"\t Cashier: James Matthew Luyon                                                                ");
            Console.WriteLine($"\t                                          *** This serves as your official Receipt ***       ");
            Console.ReadLine();


        }
           
    }
}
