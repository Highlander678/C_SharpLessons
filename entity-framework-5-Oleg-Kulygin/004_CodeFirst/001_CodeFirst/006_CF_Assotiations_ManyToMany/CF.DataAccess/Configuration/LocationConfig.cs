using System.Data.Entity.ModelConfiguration;
using CF.Data;

namespace CF.DataAccess.Configuration
{
    class LocationConfig:EntityTypeConfiguration<Location>
    {
        public LocationConfig()
        {
            HasKey(p => p.LocationID);
            Property(p => p.LocationName).IsRequired().HasMaxLength(100);
        }
    }
}
