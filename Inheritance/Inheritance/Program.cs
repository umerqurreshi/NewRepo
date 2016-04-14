using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Inheritance.Models;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            // Get all employees and format how properties are printed to the console window
            var allFullTimeEmployees = FulltimeEmployees.GetAllEmployees();

            foreach (var employee in allFullTimeEmployees)
            {
                Console.WriteLine($"{employee.Firstname} {employee.Lastname} {employee.AnnualSalary} {employee.Occupation} {employee.Age}");
            }


            // LINQ filtering /querying
            Console.ForegroundColor = ConsoleColor.Green;

            var filteredFullTimeEmployees =
                FulltimeEmployees.GetAllEmployees()
                    .Where(x => !x.Firstname.StartsWith("j", StringComparison.OrdinalIgnoreCase));

            foreach (var employee in filteredFullTimeEmployees)
            {
                Console.WriteLine($"{employee.Firstname} {employee.Lastname} {employee.AnnualSalary} {employee.Occupation} {employee.Age}");
            }

            Console.ForegroundColor = ConsoleColor.White;

            // New anonymous types
            var query = allFullTimeEmployees.Where(y => y.Firstname.Length > 5)
                .Select(z => new { AgeValue = z.Age });

            foreach (var value in query)
            {
                Console.WriteLine(value);
                Console.WriteLine(value.AgeValue);
            }


            // We have two guys with first name of Leyton. Now we want to print distinct first names
            // to the console and therefore we should only see one Leyton
            Console.ForegroundColor = ConsoleColor.Green;

            var query2 = FulltimeEmployees.GetAllEmployees().Distinct();

            foreach (var value in query2)
            {
                Console.WriteLine(value.Firstname);
            }

            // As we saw, the above example did not work. Distinct on what? Let's specify what!

            Console.ForegroundColor = ConsoleColor.White;

            var query3 = FulltimeEmployees.GetAllEmployees()
                .Select(x => new {Name = x.Firstname}).Distinct();

            foreach (var value in query3)
            {
                Console.WriteLine(value.Name);
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Parallel.ForEach(query3,
              index => {
                  Console.WriteLine("From Parallel.ForEach() loop!  " + index.Name);
              });

            Console.ReadLine();
        }
    }
}
