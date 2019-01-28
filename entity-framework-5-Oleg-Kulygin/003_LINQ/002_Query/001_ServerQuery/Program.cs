using System;
using System.Linq;
using AWModel;

namespace _001_ServerQuery
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                var query = from c in context.Customers select c;
                Console.WriteLine(query);
                Console.ReadKey();
                //SELECT ... FROM [SalesLT].[Customer] AS [Extent1]
                foreach (var customer in query) 
                {
                    Console.WriteLine(customer.CustomerID);
                }
                Console.ReadKey();
                // ... SELECT COUNT(1) AS [A1] FROM [SalesLT].[Customer] AS [Extent1]
                int customersCount = query.Count();

                Console.WriteLine("Total number of records:{0}", customersCount);
            }
        }
    }
}
