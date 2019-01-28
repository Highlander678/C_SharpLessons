using System;
using System.Linq;
using System.Data.Entity;

namespace _006_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AWEntities())
            {
                //var query = from c in db.Customer
                //            join a in db.CustomerAddress
                //            on c.CustomerID equals a.CustomerID
                //            orderby c.FirstName
                //            select new
                //            {
                //                Id = c.CustomerID,
                //                FName = c.FirstName,
                //                LName = c.LastName,
                //                AddressType = a.AddressType,
                //                CustomerAddress = c.CustomerAddress
                //            };

                var query = db.Customer.Where(c=>c.FirstName.Contains("A")).Include("CustomerAddress");
                Console.WriteLine(query);
                foreach (var customer in query)
                {
                    Console.WriteLine(customer.FirstName);

                    var adressQuery = from a in customer.CustomerAddress select a;

                    Console.WriteLine(adressQuery);
                    foreach (var customerAddress in adressQuery)
                    {
                        Console.WriteLine(customerAddress.AddressType);
                    }
                }

                //foreach (var item in query)
                //{
                //    Console.WriteLine("ID = {0}, FirstName = {1}, LastName = {2}, Address = {3}", item.Id, item.FName, item.LName, item.AddressType);
                //    foreach (var customerAddress in item.CustomerAddress)
                //    {
                //        Console.WriteLine(customerAddress.AddressID);
                //    }
                //}
            }

            Console.ReadKey();
        }
    }
}
