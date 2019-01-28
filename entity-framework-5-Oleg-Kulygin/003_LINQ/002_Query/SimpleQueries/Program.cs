using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using AWModel;

namespace SimpleQueries
{
    class Program
    {
        static void Main()
        {
            //ModifyDetailsForSalesOrder();
            //DeleteOrders();
            RetrieveAndUpdateCustomer();
            //CustomersQuery(); 
            //CustomerWithOrders();
            //CustomersThatHaveOrders();

        }

        private static void ModifyDetailsForSalesOrder()
        {
            using (var context = new AWEntities())
            {
                var detailList = context.SalesOrderDetails.Where(d => d.SalesOrderID == 71816).ToList();

                // modify an OrderDetail
                detailList[0].OrderQty = 10;
                //delete an OrderDetail
                context.DeleteObject(detailList[1]);
                //insert a new OrderDetail
                var product = context.Products.SingleOrDefault(p => p.ProductID == 711);
                var newDetail = new SalesOrderDetail
                                  {
                                      SalesOrderID = 71816,
                                      ProductID = product.ProductID,
                                      OrderQty = 2,
                                      UnitPrice = product.ListPrice,
                                      UnitPriceDiscount = 0,
                                      ModifiedDate = DateTime.Today
                                  };
                context.SalesOrderDetails.AddObject(newDetail);
                context.SaveChanges();
            }

        }

        private static void DeleteOrders()
        {
            using (var context = new AWEntities())
            {
                var orders = from o in context.SalesOrderHeaders where o.CustomerID == 721 select o;
                foreach (var order in orders)
                {
                    context.SalesOrderHeaders.DeleteObject(order);
                }
                context.SaveChanges();
            }
        }


        private static void RetrieveAndUpdateCustomer()
        {
            using (var context = new AWEntities())
            {
                var query = from c in context.Customers where c.CustomerID == 5 select c;
                var customer = query.FirstOrDefault();
                var newOrder = new SalesOrderHeader
                {
                    OrderDate = DateTime.Now,
                    DueDate = DateTime.Now.AddMonths(1),
                    ModifiedDate = DateTime.Now,
                    Comment = "Don't forget to ship this!"
                };
                context.ContextOptions.LazyLoadingEnabled = false;
                customer.SalesOrderHeaders.Add(newOrder);
                context.SaveChanges();
            }
        }


        private static void NewCustomer()
        {
            using (var context = new AWEntities())
            {
                var customer = new Customer
                {
                    FirstName = "Julie",
                    LastName = "Lerman",
                    ModifiedDate = DateTime.Now
                };
                customer.SalesOrderHeaders.Add(new SalesOrderHeader
                {
                    OrderDate = DateTime.Now,
                    DueDate = DateTime.Now.AddMonths(1),
                    ModifiedDate = DateTime.Now,
                    Comment = "Don't forget to ship this too!"
                });
                context.Customers.AddObject(customer);
                context.SaveChanges();

            }
        }

        private static void CustomerWithOrders()
        {
            var context = new AWModel.AWEntities();
            var query = from c in context.Customers
                        where c.CustomerID == 5
                        select new { c.CustomerID, c.FirstName, c.LastName, c.SalesOrderHeaders };
            var cust = query.FirstOrDefault();


        }

        private static void CustomersThatHaveOrders()
        {
            var context = new AWModel.AWEntities();
            var customers = context.Customers.Where(c => c.SalesOrderHeaders.Any()).ToList();
        }

        private static void CustomersQuery()
        {
            var context = new AWModel.AWEntities();
            var query = from c in context.Customers where c.CustomerID == 5 select c;
            var customers = query.FirstOrDefault();
        }
    }
}