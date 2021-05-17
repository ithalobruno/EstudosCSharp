using System;
using ProductsExercise.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace ProductsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProducts = new List<Product>();
            Console.Write("Enter the number of products: ");
            int numberOfProducts = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfProducts; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.WriteLine("Common, used or imported (c/u/i)? ");
                char opt = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(opt == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProducts.Add(new ImportedProduct(name, price, customFee));
                }
                else if (opt == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    listProducts.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    listProducts.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.Write("PRICE TAGS:");

            foreach(Product pr in listProducts)
            {
               Console.WriteLine(pr.PriceTag());
            }

        }
    }
}
