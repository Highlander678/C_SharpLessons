using System;
using System.Linq;

namespace AW_DB_First
{
    class Program
    {
        static void Main()
        {
            using (var context = new AdventureWorksLT2012_DataEntities())
            {

                var query = from customer in context.Customers
                            where customer.CustomerAddresses.Any()
                            orderby customer.FirstName
                            select new { customer.FirstName, customer.CustomerAddresses };


                foreach (var customer in query.Take(10))
                {
                    Console.WriteLine(customer.FirstName);

                    foreach (var customerAddress in customer.CustomerAddresses)
                    {
                        Console.WriteLine("\t" + customerAddress.Address.StateProvince);
                    }
                }
            }
        }
    }
}
