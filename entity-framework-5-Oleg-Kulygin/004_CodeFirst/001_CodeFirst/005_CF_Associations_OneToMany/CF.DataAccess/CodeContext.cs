using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class CodeContext : DbContext
    {
        public CodeContext()
            : base(@"data source=.;initial catalog=MyDB3;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
