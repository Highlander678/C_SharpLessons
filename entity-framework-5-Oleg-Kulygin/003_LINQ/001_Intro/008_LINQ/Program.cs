using System;
using System.Linq;

// let - представляет новый локальный идентификатор, на который можно ссылаться в остальной части запроса.
// Его можно представить, как локальную переменную видимую только внутри выражения запроса.

namespace _008_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AWEntities())
            {
                var query = from c in db.Customer
                            let fullName = c.FirstName + "  " + c.LastName
                            orderby fullName
                            select fullName;

                Console.WriteLine(query);
                Console.ReadKey();

                foreach (var item in query)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
