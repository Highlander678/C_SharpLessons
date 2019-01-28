using System.Data.Entity;

namespace _007_CodeFirst
{
    public class ManContext : DbContext
    {
        public DbSet<Man> Men { get; set; }
    }
}