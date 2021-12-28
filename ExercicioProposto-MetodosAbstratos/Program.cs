using System;
using System.Globalization;
using System.Collections.Generic;
using ExercicioProposto_MetodosAbstratos.Entities;

namespace ExercicioProposto_MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Element> listElement = new List<Element>();

            Console.Write("Enter the number of tax payers: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                Console.Clear();
                Console.WriteLine($"Tax payer #{i} data:");
                Console.WriteLine();

                Console.Write("Individual or company (i/c): ");
                char inputElementIs = char.Parse(Console.ReadLine().Trim().ToLower());
                while (inputElementIs != 'i' && inputElementIs != 'c')
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a valid option!");
                    Console.Write("Individual or company (i/c): ");
                    inputElementIs = char.Parse(Console.ReadLine().Trim().ToLower());
                }

                if (inputElementIs == 'i')
                {
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string inputName = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Anual income: ");
                    double inputIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    Console.Write("Health expenditures: ");
                    double inputHealth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listElement.Add(new Individual(inputHealth, inputName, inputIncome));

                    if (i != count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("individual sucessfuly registred");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("individual sucessfuly registred");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string inputName = Console.ReadLine();

                    Console.WriteLine();
                    Console.Write("Anual income: ");
                    double inputIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine();
                    Console.Write("Number of employees: ");
                    int inputEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listElement.Add(new Company(inputEmployees, inputName, inputIncome));

                    if (i != count)
                    {
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("company sucessfuly registred");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("individual sucessfuly registred");
                        System.Threading.Thread.Sleep(2000);
                    }
                }
            }

            Console.Clear();
            double totalTaxes = 0.00;
            Console.WriteLine("TAXES PAID:");
            foreach (Element element in listElement)
            {
                Console.WriteLine($"{element.Name.ToUpper()}: ${element.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += element.Tax();
            }
            Console.WriteLine();
            Console.Write("TOTAL TAXES: $" + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
