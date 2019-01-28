using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LINQDataContext())
            {
                var query = from c in db.PersonNames
                            select c;

                foreach (var item in query)
                {
                    Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}", item.ID, item.FirstName, item.LastName);
                }

                Console.ReadKey();
            }
        }
    }
}
