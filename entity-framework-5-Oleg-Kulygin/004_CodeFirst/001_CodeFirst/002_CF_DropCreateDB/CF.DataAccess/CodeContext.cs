using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class CodeContext : DbContext
    {
        public CodeContext():this("dbContext")
        {
            
        }

        public CodeContext(string connectionString)
            : base(connectionString)
        {

        }

        public DbSet<Attendee> Attendees { get; set; }
    }
}
