using AlfandegaProduct_s.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using AlfandegaProduct_s.Entities.Exceptions;

namespace AlfandegaProduct_s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            try
            {
                Console.Write("Enter the number of products: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Product #{i} data:");
                    Console.Write("Common, used or imported (c/u/i)? ");
                    char ch = char.Parse(Console.ReadLine().ToUpper());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (ch == 'C')
                    {
                        list.Add(new Product(name, price));
                    }
                    else if (ch == 'U')
                    {
                        Console.Write("Manufacture date (DD/MM/YYYY): ");
                        DateTime dateTime = DateTime.Parse(Console.ReadLine());

                        list.Add(new UsedProduct(name, price, dateTime));
                    }
                    else if (ch == 'I')
                    {
                        Console.Write("Customs fee: ");
                        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        list.Add(new ImportedProduct(name, price, customFee));
                    }

                }
            } 
            catch(DomainException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag()); 
            }
        }
    }
}
