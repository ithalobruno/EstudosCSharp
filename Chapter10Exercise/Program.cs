using System;
using Chapter10Exercise.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Chapter10Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers:");
            int numberPayers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?: ");
                char opt = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(opt == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healtExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(name, anualIncome, healtExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, nEmployees));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TEXT PAID");
            double sum = 0.00;
            foreach(TaxPayer tax in list)
            {
                Console.WriteLine(tax.Name + " - $" + tax.Tax());
                sum += tax.Tax();
            }
            Console.Write("TOTAL TAXES: - $" + sum);
        }
    }
}
