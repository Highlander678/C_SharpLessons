namespace _005_EDM_PartialClass
{
    public partial class Customer
    {
        public override string ToString()
        {
            return string.Format("{0}  {1}  {2}", this.CustomerID, this.FirstName, this.LastName);
        }
    }
}
