using System;
using System.Linq;

namespace _005_EDM_PartialClass
{
    class Program
    {
        static void Main()
        {
            using (var db = new AWEntities())
            {
                db.Customer
                    .Where(c => c.CustomerID < 10)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }

            Console.ReadKey();
        }
    }
}
