using System;
using System.Collections.Generic;
using System.Linq;
using AWModel;

namespace _002_LocalQuery
{
    static class Program
    {
        static void Main()
        {
            IEnumerable<Customer> customers;

            using (var context = new AdventureWorksLT2012Entities())
                customers = context.GetCustomersFromLocal();

            // Not interacting with SQL Server!!! (Proof: Context is Disposed || Look @ Profiler)
            foreach (var customer in customers) 
                Console.WriteLine(customer.FirstName);
            int customersCount = customers.Count(); 

            Console.WriteLine("Total number of records:{0}", customersCount);
        }

        private static IEnumerable<Customer> GetCustomersFromLocal(this AdventureWorksLT2012Entities context)
        {
            IQueryable<Customer> query = from c in context.Customers select c;
            IEnumerable<Customer> customers = query.ToList(); //SELECT ... FROM [SalesLT].[Customer] AS [Extent1]
            return customers;
        }
    }
}
