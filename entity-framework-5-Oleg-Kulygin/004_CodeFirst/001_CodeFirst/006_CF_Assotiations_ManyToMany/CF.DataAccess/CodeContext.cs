using System.Data.Entity;
using CF.Data;
using CF.DataAccess.Configuration;

namespace CF.DataAccess
{
    public class CodeContext : DbContext
    {
        public CodeContext()
            : base(@"data source=(localDb)\v11.0;initial catalog=MyDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AttendeeConfig());
            modelBuilder.Configurations.Add(new LocationConfig());
            modelBuilder.Configurations.Add(new SessionConfig());
        }

        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
