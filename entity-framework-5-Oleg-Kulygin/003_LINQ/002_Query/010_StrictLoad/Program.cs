using System;
using System.Data.Entity;
using System.Linq;
using AWModel;

namespace _010_StrictLoad
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                context.Configuration.LazyLoadingEnabled = false;
              
                context.Customers.Load();
                
                var query = from order in context.SalesOrderHeaders
                            select order;
                //SELECT 
                //...
                //FROM  [SalesLT].[SalesOrderHeader] AS [Extent1]
               
                Console.WriteLine(query);
                var ordersList = query.ToList();
                foreach (var order in ordersList)
                {
                    //Нет запросов к БД!!!
                    if (order.Customer != null)
                    Console.WriteLine(order.Customer.LastName);
                }
            }
        }
    }
}
