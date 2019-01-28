using System;
using System.Linq;
using AWModel;

namespace _008_LazyLoad
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                context.Configuration.LazyLoadingEnabled = true; //Code-First defaults: true, DB/ModelFirst - See EDMX Props
                
                //SELECT
                //...
                //FROM [SalesLT].[SalesOrderHeader] AS [Extent1]
                var query = from order in context.SalesOrderHeaders
                            select order;
                Console.WriteLine(query);
                var ordersList = query.ToList();

                foreach (var order in ordersList)
                {
                    // На каждой итерации обращение к БД!!!!
                    if (order.Customer != null)
                        //exec sp_executesql N'SELECT 
                        //...
                        //FROM [SalesLT].[Customer] AS [Extent1]
                        //WHERE [Extent1].[CustomerID] = @EntityKeyValue1',N'@EntityKeyValue1 int',@EntityKeyValue1=30102
                        Console.WriteLine(order.Customer.LastName);
                }
            }
        }

    }
}
