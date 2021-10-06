using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
                bool menu = true;
                while (menu)
                {
                    menu = MainMenu();
                }
              
        }

        private static bool MainMenu()
        {
           
                Console.Clear();
                Console.WriteLine("\t\t*************** MENU ****************");
                Console.WriteLine("\t\t[1]. Customer Details");
                Console.WriteLine("\t\t[2]. Item Description");
                Console.WriteLine("\t\t[3]. Sales Invoice");
                Console.WriteLine("\t\t[4]. Delete Data");
                Console.WriteLine("\t\t[5]. Exit");
                Console.WriteLine("\t\t*************************************");
                Console.WriteLine("\t\t*************************************");
                Console.Write("\t\tEnter Choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CustomerDetails();
                        return true;
                    case "2":
                        ItemDescription();
                        return true;
                    case "3":
                        SalesInvoice();
                        return true;
                    case "4":
                        DeleteData();
                        return true;
                    case "5":
                        return false;
                    default:
                        Console.WriteLine("Invalid Choice!");
                        return true;
                }
        }

        public static void CustomerDetails()
        {
            string file1 = @"C:\Users\james matthew luyon\Name.txt";
            string file2 = @"C:\Users\james matthew luyon\Address.txt";
            string file3 = @"C:\Users\james matthew luyon\ContactNumber.txt";

            using (StreamWriter f1 = new StreamWriter(file1))
            {
                Console.WriteLine("\n\n\t\t*************************************");
                Console.WriteLine("\t\t**********(CustomerDetails)**********");
                Console.Write("\n\t\tFull Name: ");
                var Name = Console.ReadLine();
                f1.Write(Name);
                f1.Close();
            }

            using (StreamWriter f2 = new StreamWriter(file2))
            {
                Console.Write("\t\tAddress: ");
                var address = Console.ReadLine();
                f2.Write(address);
                f2.Close();
            }

            using (StreamWriter f3 = new StreamWriter(file3))
            {
                Console.Write("\t\tContact Number: ");
                var contact = Console.ReadLine();
                f3.Write(contact);
                f3.Close();
            } 
        }

        public static void ItemDescription()
        {
            string f4 = @"C:\Users\james matthew luyon\Quantity.txt";
            string f5 = @"C:\Users\james matthew luyon\ItemDetails.txt";
            string f6 = @"C:\Users\james matthew luyon\Price.txt";
            string f7 = @"C:\Users\james matthew luyon\Cash.txt";

            using (StreamWriter QTY = new StreamWriter(f4))
            {
                Console.WriteLine("\n\n\t\t*************************************");
                Console.WriteLine("\t\t************(ItemDetails)************");
                Console.Write("\n\t\tQuantity: ");
                string qty = Console.ReadLine();
                long quantity = Convert.ToInt32(qty);
                QTY.Write(qty);
                QTY.Close();
            }
            using (StreamWriter ItemDcrptn = new StreamWriter(f5))
            {
                Console.Write("\t\tItem Description: ");
                var description = Console.ReadLine();
                ItemDcrptn.Write(description);
                ItemDcrptn.Close();
            }
            using (StreamWriter Price = new StreamWriter(f6))
            {
                Console.Write("\t\tPrice: ");
                string Sprice = Console.ReadLine();
                float price = Convert.ToSingle(Sprice);
                Price.Write(price);
                Price.Close();
            }
            using (StreamWriter Cash = new StreamWriter(f7))
            {
                Console.Write("\t\tCash Tendered: ");
                var cash = Console.ReadLine();
                Cash.Write(cash);
                Cash.Close();
            }
        }

        public static void DeleteData()
        {
            string clearName = @"C:\Users\james matthew luyon\Name.txt";
            string clearAddress = @"C:\Users\james matthew luyon\Address.txt";
            string clearContactNum = @"C:\Users\james matthew luyon\ContactNumber.txt";
            string clearQty = @"C:\Users\james matthew luyon\Quantity.txt";
            string clearItem = @"C:\Users\james matthew luyon\ItemDetails.txt";
            string clearPrice = @"C:\Users\james matthew luyon\Price.txt";
            string clearCash = @"C:\Users\james matthew luyon\Cash.txt";

            File.WriteAllText(clearName, string.Empty);
            File.WriteAllText(clearAddress, string.Empty);
            File.WriteAllText(clearContactNum, string.Empty);
            File.WriteAllText(clearQty, string.Empty);
            File.WriteAllText(clearItem, string.Empty);
            File.WriteAllText(clearPrice, string.Empty);
            File.WriteAllText(clearCash, string.Empty);

        }

        public static void SalesInvoice()
        {
            try
            {
                Console.SetCursorPosition(15, 11);
                Console.WriteLine("==============================JML Computer System Company==============================");
                Console.SetCursorPosition(25, 12);
                Console.WriteLine(" No.405 2D El Grande Ave, Cor. Canton St, BF Homes, Parañaque City");
                Console.SetCursorPosition(40, 13);
                Console.WriteLine("\t   Sales Invoice");

                using (StreamReader ReadName = new StreamReader(@"C:\Users\james matthew luyon\Name.txt"))
                {
                    string RName = ReadName.ReadToEnd();
                    Console.SetCursorPosition(20, 15); 
                    Console.WriteLine("Sold to: " + RName);
                }
                using (StreamReader ReadAddress = new StreamReader(@"C:\Users\james matthew luyon\Address.txt"))
                {
                    string RAddress = ReadAddress.ReadToEnd();
                    Console.SetCursorPosition(20, 16);  
                    Console.WriteLine("Address: " + RAddress);
                }

                using (StreamReader ReadContactNum = new StreamReader(@"C:\Users\james matthew luyon\ContactNumber.txt"))
                {
                    string RCN = ReadContactNum.ReadToEnd();
                    Console.SetCursorPosition(70, 15);
                    Console.Write($"Date: {DateTime.Now.ToShortDateString()}");
                    Console.SetCursorPosition(70, 16);
                    Console.WriteLine("Contact Number: " + RCN);
                }

                using (StreamReader ReadQuantity = new StreamReader(@"C:\Users\james matthew luyon\Quantity.txt"))
                { 
             
                    int quantity;
                    Console.SetCursorPosition(15, 17);
                    Console.Write("=======================================================================================");

                    string qty = ReadQuantity.ReadToEnd();
                    quantity = Convert.ToInt32(qty);
                    Console.SetCursorPosition(20, 18);
                    Console.WriteLine("Qty     |");
                    Console.SetCursorPosition(15, 19);
                    Console.Write("=======================================================================================");
                    Console.SetCursorPosition(20, 20);
                    Console.WriteLine(quantity);

                    using (StreamReader aF = new StreamReader(@"C:\Users\james matthew luyon\ItemDetails.txt"))
                    {
                        string description = aF.ReadToEnd();
                        Console.SetCursorPosition(30, 18);
                        Console.WriteLine("     Unit Description              |");
                        Console.SetCursorPosition(32, 20);
                        Console.WriteLine(description);

                        using (StreamReader bF = new StreamReader(@"C:\Users\james matthew luyon\Price.txt"))
                        {
                            string Price = bF.ReadToEnd();
                            float price = Convert.ToInt32(Price);
                            Console.SetCursorPosition(68, 18);
                            Console.WriteLine("   Price    |");
                            Console.SetCursorPosition(70, 20);
                            Console.WriteLine(Price);


                            using (StreamReader gF = new StreamReader(@"C:\Users\james matthew luyon\Cash.txt"))
                            {
                                string cash = gF.ReadToEnd();
                                long Cash = Convert.ToInt32(cash);
                                float total = price * quantity; 
                                Console.SetCursorPosition(87, 18);
                                Console.Write(" Amount ");
                                Console.SetCursorPosition(88, 20);
                                Console.WriteLine(total);
                                Console.SetCursorPosition(15, 25);
                                Console.Write("=======================================================================================");
                                Console.SetCursorPosition(15, 26);
                                Console.Write("=======================================================================================");
                                Console.SetCursorPosition(65, 27);
                                Console.WriteLine("Total Amount Due: | " + total);
                                Console.SetCursorPosition(15, 28);
                                Console.Write("=======================================================================================");

                                Console.SetCursorPosition(65, 29);
                                double VatSales = total / 1.12;
                                Console.WriteLine("Vatable Sales:    | " + VatSales);

                                Console.SetCursorPosition(65, 30);
                                double Vat = VatSales * 0.12;
                                Console.WriteLine("VAT:              | " + Vat);

                                Console.SetCursorPosition(65, 31);
                                Console.Write("Cash Tendered:    | " + cash);

                                Console.SetCursorPosition(65, 32);
                                double totalSales = VatSales + Vat;
                                Console.WriteLine("Total Sales:      | " + totalSales);

                                Console.SetCursorPosition(65, 33);
                                float change = Cash - total;
                                Console.WriteLine("Change:           | " + change);
                                Console.SetCursorPosition(15, 34);
                                Console.Write("=======================================================================================");
                                Console.SetCursorPosition(15, 35);
                                Console.WriteLine("Cashier: James Matthew Luyon");
                                Console.WriteLine("                                      *** This serves as your official Receipt ***");
                                Console.SetCursorPosition(15, 37);
                                Console.Write("=======================================================================================");

                            }
                        }
                    }
                }
      
            }
             catch(FormatException)
            {
                Console.WriteLine("\n\n\t\tIncomplete Data!.... Please Fill the Data.");
            }
            Console.ReadLine();
        }
    }
}
