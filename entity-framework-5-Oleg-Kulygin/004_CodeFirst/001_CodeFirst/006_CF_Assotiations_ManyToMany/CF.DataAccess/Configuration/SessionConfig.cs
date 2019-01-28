using System.Data.Entity.ModelConfiguration;
using CF.Data;

namespace CF.DataAccess.Configuration
{
    class SessionConfig:EntityTypeConfiguration<Session>
    {
        public SessionConfig()
        {
            HasKey(p => p.SessionID);
            Property(p => p.SessionName).IsRequired().HasMaxLength(200);
            //HasOptional(p => p.Attendees);
        }
    }
}
