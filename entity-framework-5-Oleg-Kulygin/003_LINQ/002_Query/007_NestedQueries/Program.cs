using System;
using System.Linq;
using AWModel;

namespace _007_NestedQueries
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                var query = from customer in context.Customers 
                            orderby customer.FirstName 
                            select customer;

                Console.WriteLine(query);
                Console.WriteLine();

                var nestedQuery = from a in query 
                                  where a.CustomerID < 10 
                                  select a;
                Console.WriteLine(nestedQuery);

                //SELECT ...
                //FROM [SalesLT].[Customer] AS [Extent1]
                //WHERE [Extent1].[CustomerID] < 1000
                //ORDER BY [Extent1].[FirstName] ASC
                foreach (var customer in nestedQuery)
                {
                    Console.WriteLine((int)customer.CustomerID);
                }

            }
        }
    }
}
