using System;
using System.Linq;
using AWModel;

namespace _005_Projection
{
    class Program
    {
        static void Main()
        {
            PrintCustomCustomersProjection();
        }

        private static void PrintCustomCustomersProjection()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                var query = from c in context.Customers select new { c.CustomerID, c.FirstName, c.LastName };
                Console.WriteLine(query);
                Console.ReadKey();

                //SELECT 1 AS [C1], [Extent1].[CustomerID] AS [CustomerID], [Extent1].[FirstName] AS [FirstName], [Extent1].[LastName] AS [LastName]
                //FROM [SalesLT].[Customer] AS [Extent1]
                foreach (var customer in query)
                {
                    Console.WriteLine("{0} {1}", customer.LastName, customer.FirstName);
                }
            }
        }

    }
}
