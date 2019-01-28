using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_EDM_PartialMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AWEntities())
            {
                var query = (from c in db.Customer select c).First();
                query.Title = "MyTitle";
            }

            Console.ReadKey();
        }
    }
}
