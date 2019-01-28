using System;
using System.Collections.Generic;
using System.Linq;
using AWModel;


namespace SimpleQueries
{
    internal class QueryExamples
    {
        private static void Main()
        {
            //   GetCustomersFromServer();
            //  GetCustomersFromLocal();
            //    GetFirstCustomerFromServer();
            //   GetSomeCustomersFromServerSorted();
            //   GetCustomCustomersFromServer();
            //   GetSomeCustomersFromServerSortedWithParameter();
            //   NestedQueries();
            //       NavigationQueriesLazyLoad();
            //   NavigationQueriesEagerLoad();
        }

      


        

       //Doing only the single query
     

        private static void NavigationQueriesLazyLoad()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                var query = from order in context.SalesOrderHeaders
                            select order;
                //SELECT 
                //[Extent1].[SalesOrderID] AS [SalesOrderID], 
                // ...
                //[Extent1].[ModifiedDate] AS [ModifiedDate]
                // No Extent2 in resultQuery
                //FROM  [SalesLT].[SalesOrderHeader] AS [Extent1]
                //INNER JOIN [SalesLT].[Customer] AS [Extent2] ON [Extent1].[CustomerID] = [Extent2].[CustomerID]
                //WHERE N'Roger' = [Extent2].[FirstName]
                var ordersList = query.ToList();
                foreach (var order in ordersList)
                {
                    // На каждой итерации!!!!
                    //exec sp_executesql N'SELECT 
                    //[Extent1].[CustomerID] AS [CustomerID], 
                    // ...
                    //[Extent1].[ModifiedDate] AS [ModifiedDate]
                    //FROM [SalesLT].[Customer] AS [Extent1]
                    //WHERE [Extent1].[CustomerID] = @EntityKeyValue1',N'@EntityKeyValue1 int',@EntityKeyValue1=30102
                    Console.WriteLine(order.Customer.LastName);
                }
            }
        }

        private static void NavigationQueriesEagerLoad()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {
                var query = from order in context.SalesOrderHeaders.Include("Customer")
                            select order;
                //SELECT 
                //[Extent1].[SalesOrderID] AS [SalesOrderID], 
                //[Extent1].[RevisionNumber] AS [RevisionNumber], 
                // ...
                //[Extent1].[ModifiedDate] AS [ModifiedDate], 
                //[Extent2].[CustomerID] AS [CustomerID1], 
                //...
                //[Extent2].[ModifiedDate] AS [ModifiedDate1]
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

