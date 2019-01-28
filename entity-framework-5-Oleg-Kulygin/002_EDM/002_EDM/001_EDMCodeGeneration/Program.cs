using System;

namespace _002_EDM
{
    class Program
    {
        static void Main()
        {
            using (var context = new AWLT2012Entities())
            {
                foreach (var customer in context.Customers)
                {
                    foreach (var customerAddress in customer.CustomerAddresses)
                    {
                        Console.WriteLine(customerAddress.Address.City);
                    }
                }
            }
        }
    }
}
