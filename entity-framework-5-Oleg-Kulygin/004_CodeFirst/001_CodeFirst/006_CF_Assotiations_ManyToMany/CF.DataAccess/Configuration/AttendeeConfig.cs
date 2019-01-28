using CF.Data;
using System.Data.Entity.ModelConfiguration;

namespace CF.DataAccess
{
    public class AttendeeConfig : EntityTypeConfiguration<Attendee>
    {
        public AttendeeConfig()
        {
            HasKey(p => p.AttendeeID);
            Property(p => p.FirstName).IsRequired().HasMaxLength(50);
            Property(p => p.LastName).IsRequired().HasMaxLength(50);
        }
    }
}
