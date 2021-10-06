using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            long custid, qty, price, amount;
            double vsales, vat, change, ctend;
            string name, address, description;

            bool menu = true;
            int choice = Convert.ToInt32(Menu);
            while (menu)
            {
               menu = MainMenu();
            }
        }

        public static bool MainMenu()
        {
            bool menu = true;
            int choice = Convert.ToInt32(menu);
            Console.Clear();
            Console.WriteLine("\t========== Menu ==========");
            Console.WriteLine("\t[1]. Customer Details");
            Console.WriteLine("\t[2]. Item Details");
            Console.WriteLine("\t[3]. Sales Invoice");
            Console.WriteLine("\t[4]. Exit");
            Console.WriteLine("\t==========================");
            Console.Write("\tEnter Choice: ");

            switch(Console.ReadLine())
            {
                case "1": CustomerDetails();
                    return true;

                case "2": ItemDetails();
                    return true;

                case "3":
                    Console.WriteLine("\n\t==============================Luyon Computer System Corporation===============================");
                    Console.WriteLine("\t=                123456 Pag-Asang Makapagtapos Ave, BF Homes,  Parañaque City,                =");
                    Console.WriteLine("\t=                                    Sales Invoice                                            =");
                    Console.WriteLine("\t=                                                                                             =");
                    Console.WriteLine($"\t=    Sold to: {name}                                     Date: {DateTime.Now}            =");
                    Console.WriteLine($"\t=    Address: {address}                                      Contact Number: {custid}         =");
                    Console.WriteLine($"\t===============================================================================================");
                    Console.WriteLine($"\t=     Qty    |              Unit Description                |      Price       |     Amount   =");
                    Console.WriteLine($"\t===============================================================================================");
                    Console.WriteLine($"\t=     {qty}      | {description}                                | {price}          | {amount}     =");
                    Console.WriteLine($"\t=            |                                              |                  |              =");
                    Console.WriteLine($"\t=            |                                              |                  |              =");
                    Console.WriteLine($"\t=            |                                              |                  |              =");
                    Console.WriteLine($"\t=            |                                              |                  |              =");
                    Console.WriteLine($"\t===============================================================================================");
                    Console.WriteLine($"\t===============================================================================================");
                    Console.WriteLine($"\t=                                                            Total Amount Due: | {amount}      =");
                    Console.WriteLine($"\t===============================================================================================");
                    Console.WriteLine($"\t=                                                            Vatable Sales:    | {vsales}      =");
                    Console.WriteLine($"\t=                                                                      Vat:    | {vat}         =");
                    Console.WriteLine($"\t=                                                            Cash Tendered:    | {ctend}       =");
                    Console.WriteLine($"\t=                                                                   Change:    | {change}      =");
                    Console.WriteLine($"\t===============================================================================================");
                    Console.WriteLine($"\t= Cashier: James Matthew Luyon                                                                =");
                    Console.WriteLine($"\t=                                          *** This serves as your official Receipt ***       =");
                    Console.ReadLine(); 
                    return true;

                case "4": return false;

                default: Console.WriteLine("Invalid Choice"); return true;
                    
                
            }
        }

        public static void CustomerDetails()
        {
            Console.Write("\tContact Number: ");
            custid = long.Parse(Console.ReadLine());
            Console.Write("\tName of the customer: ");
            name = Console.ReadLine();
            Console.Write("\tAddress of the customer: ");
            address = Console.ReadLine();
        }

        public static void ItemDetails()
        {
            Console.Write("\tUnit Description: ");
            description = Console.ReadLine();
            Console.Write("\tQuantity: ");
            qty = long.Parse(Console.ReadLine());
            Console.Write("\tPrice of Product: ");
            price = long.Parse(Console.ReadLine());
            Console.Write("\tCash Tendered: ");
            ctend = double.Parse(Console.ReadLine());
            amount = qty * price;
            vsales = price * 0.12;
            vat = vsales * 1.12;
            change = ctend - amount;
        }

       

      
    }
}
