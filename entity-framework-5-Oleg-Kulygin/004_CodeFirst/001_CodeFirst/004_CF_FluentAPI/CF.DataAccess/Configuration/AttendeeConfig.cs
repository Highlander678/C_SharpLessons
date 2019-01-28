using CF.Data;
using System.Data.Entity.ModelConfiguration;

namespace CF.DataAccess
{
    public class AttendeeConfig : EntityTypeConfiguration<Attendee>
    {
        public AttendeeConfig()
        {
            HasKey(p => p.AttendeeTrackingID); ;
            Property(p => p.LastName).IsRequired().HasMaxLength(100);
            Property(p => p.DateAdded).IsOptional().HasColumnName("Created").HasColumnType("datetime2");
        }
    }
}
