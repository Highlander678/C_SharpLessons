//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _007_Delete
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductModel
    {
        public ProductModel()
        {
            this.Product = new HashSet<Product>();
            this.ProductModelProductDescription = new HashSet<ProductModelProductDescription>();
        }
    
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductModelProductDescription> ProductModelProductDescription { get; set; }
    }
}
