using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_EDM_PartialMethod
{
    public partial class Customer
    {
        public void Write()
        {
            Console.WriteLine(string.Format("{0}  {1}  {2}", this.CustomerID, this.FirstName, this.LastName));
        }
    }
}
