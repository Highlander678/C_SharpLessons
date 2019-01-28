using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class CodeContext : DbContext
    {
        public CodeContext()
        {

        }

        public CodeContext(string connString)
            :base(connString)
        {
            
        }

        public DbSet<Attendee> Attendees { get; set; }
    }
}
