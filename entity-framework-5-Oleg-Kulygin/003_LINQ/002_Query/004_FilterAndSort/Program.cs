using System;
using System.Linq;
using AWModel;

namespace _004_FilterAndSort
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012Entities())
            {

                var query = from c in context.Customers
                            where c.FirstName == "Robert"
                            orderby c.LastName
                            select c;

                Console.WriteLine(query);
                Console.WriteLine();
                foreach (var customer in query)

                //SELECT ... FROM [SalesLT].[Customer] AS [Extent1]
                //           WHERE N'Robert' = [Extent1].[FirstName]
                //           ORDER BY [Extent1].[LastName] ASC
                {
                    Console.WriteLine(customer.LastName);
                }

                Console.WriteLine(new string('-', 40));

                //--------------Выполнение запроса с внешним параметром (строковая переменная customerName)
                var customerName = "Robert";
                query = from c in context.Customers
                        where c.FirstName == customerName
                        orderby c.LastName
                        select c;

                Console.WriteLine(query);
                Console.WriteLine();

                foreach (var customer in query)

                //SELECT ... FROM [SalesLT].[Customer] AS [Extent1]
                //           WHERE [Extent1].[FirstName] = @p__linq__0
                //           ORDER BY [Extent1].[LastName] ASC
                {
                    Console.WriteLine(customer.LastName);
                }
            }
        }
    }
}
