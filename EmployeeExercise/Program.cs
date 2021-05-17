using System;
using System.Collections.Generic;
using EmployeeExercise.Entities;
using System.Globalization;
namespace EmployeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 1; i<= numberOfEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char opt = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(opt == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listEmployee.Add(new OutsourceEmployee(additionalCharge, name, hours, valuePerHour));
                }
                else
                {
                    listEmployee.Add(new Employee(name, hours, valuePerHour));
                }
               
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS ");
            foreach (Employee emp in listEmployee)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment());
            }
        }
    }
}
