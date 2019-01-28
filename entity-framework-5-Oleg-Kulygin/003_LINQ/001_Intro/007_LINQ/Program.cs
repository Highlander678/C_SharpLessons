using System;
using System.Linq;

namespace _007_LINQ
{
    class Program
    {
        static void Main()
        {
            using (var db = new AWEntities())
            {
                IQueryable<Customer> query = from c in db.Customer
                                             select c;

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
