using System;
using System.Linq;
using AWModel;

namespace _003_First
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                IQueryable<Customer> query = from c in context.Customers select c;

                Customer firstCustomer = query.First(); //SELECT TOP (1) ... FROM [SalesLT].[Customer] AS [c] (Look @ profiler)

                Console.WriteLine("First Customer: {0} {1}", firstCustomer.FirstName, firstCustomer.LastName);
            }
        }

      
    }
}
