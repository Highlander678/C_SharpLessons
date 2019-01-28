using System;
using System.Linq;

namespace _009_LINQ
{
    class Program
    {
        static void Main()
        {
            using (var db = new AWEntities())
            {
                var query = from c in db.Customer
                            group c by c.Title into cus
                            select new { Key = cus.Key, Count = cus.Count(), Group = cus };

                Console.WriteLine(query);
                Console.WriteLine(new string('-',40));
                Console.ReadKey();

                foreach (var group in query)
                {
                    if (group.Key != null)
                    {
                        Console.Write("Title = {0} ,", group.Key);
                        Console.WriteLine("Count = {0}", group.Count);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
