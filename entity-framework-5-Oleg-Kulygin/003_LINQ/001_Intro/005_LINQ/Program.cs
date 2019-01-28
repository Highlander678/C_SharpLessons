using System;
using System.Collections.Generic;
using System.Linq;

namespace _005_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee
                {
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 94000,
                    StartDate = DateTime.Parse("1/4/1992")
                },
                new Employee
                {
                    FirstName = "Petr",
                    LastName = "Petrov",
                    Salary = 123000,
                    StartDate = DateTime.Parse("12/3/1985")
                },
                new Employee
                {
                    FirstName = "Andrey",
                    LastName = "Andreev",
                    Salary = 1000000,
                    StartDate = DateTime.Parse("1/12/2005")
                }
            };

            //Использование вызовов статических методов.
            var query = Enumerable.Select(
                Enumerable.Where(
                employees, emp => emp.Salary > 100000),
                emp => new { LastName = emp.LastName, FirstName = emp.FirstName });

            foreach (var item in query)
            {
                Console.WriteLine("FirstName = {0}, LastName = {1}",
                                   item.FirstName, item.LastName);
            }

            Console.ReadKey();
        }
    }
}
