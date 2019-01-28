using CF.Data;
using System.Data.Entity.ModelConfiguration;

namespace CF.DataAccess
{
    public class AttendeeRenameTableConfig : EntityTypeConfiguration<Attendee>
    {
        public AttendeeRenameTableConfig()
        {
            HasKey(p => p.AttendeeTrackingID); ;
            Property(p => p.LastName).IsRequired().HasMaxLength(100);

            ToTable("Attendees");
        }
    }
}
