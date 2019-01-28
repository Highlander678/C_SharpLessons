using CF.Data;
using System.Data.Entity.ModelConfiguration;

namespace CF.DataAccess
{
    public class AttendeeSplittedEntityConfig : EntityTypeConfiguration<Attendee>
    {
        public AttendeeSplittedEntityConfig()
        {
            HasKey(p => p.AttendeeTrackingID); ;
            Property(p => p.LastName).IsRequired().HasMaxLength(100);
            
            Map(e =>
            {
                e.Properties(at=>new {at.AttendeeTrackingID,at.DateAdded});
                e.ToTable("AttendeeDates");
            });
            
            Map(e =>
            {
                e.Properties(at=>new {at.AttendeeTrackingID,at.LastName});
                e.ToTable("AttendeeNames");
            });
            
       
        }
    }
}
