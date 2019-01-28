using AWModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Data.EntityClient;
using System.Data;

namespace QueryTests
{
    
  
  [TestClass()]
  public class SalesEntitiesTest
  {

     [TestMethod()]
     public void GetSomeCustomers()
    {

      var context = new AdventureWorksLT2012Entities();
      var query = from c in context.Customers orderby c.LastName where c.FirstName=="Robert" select c;
      var customers =query.ToList();

      foreach (var cust in customers)
        Debug.WriteLine(cust.LastName.Trim() + ", " + cust.FirstName);
     }

     [TestMethod()]
     public void GetSomeCustomersUsingLinqMethod()
     {

       var context = new AdventureWorksLT2012Entities();
       var query = context.Customers.OrderBy(c => c.LastName).Where(c => c.FirstName == "Robert");
         var objectQuery = query as ObjectQuery<Customer>;
         Debug.WriteLine(objectQuery.CommandText);
       var customers = query.ToList();

       foreach (var cust in customers)
         Debug.WriteLine(cust.LastName.Trim() + ", " + cust.FirstName);
     }
    

   
  }
}
