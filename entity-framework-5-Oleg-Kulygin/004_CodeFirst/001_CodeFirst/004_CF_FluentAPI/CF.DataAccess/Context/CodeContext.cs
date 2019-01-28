using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class CodeContext : DbContext
    {
        public CodeContext()
            : base("data source=.;initial catalog=MyDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }

        public DbSet<Attendee> Attendees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AttendeeConfig());
        }
    }
}
