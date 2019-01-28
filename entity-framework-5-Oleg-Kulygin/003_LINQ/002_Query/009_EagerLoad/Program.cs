using System;
using System.Linq;
using AWModel;

namespace _009_EagerLoad
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                context.Configuration.LazyLoadingEnabled = false;

                var query = from order in context.SalesOrderHeaders.Include("Customer")
                            select order;
                //SELECT 
                //...
                //FROM  [SalesLT].[SalesOrderHeader] AS [Extent1]
                //INNER JOIN [SalesLT].[Customer] AS [Extent2] ON [Extent1].[CustomerID] = [Extent2].[CustomerID]

                var ordersList = query.ToList();
                foreach (var order in ordersList)
                {
                    //Нет запросов к БД!!!
                    Console.WriteLine(order.Customer.LastName);
                }
            }
        }
    }
}
