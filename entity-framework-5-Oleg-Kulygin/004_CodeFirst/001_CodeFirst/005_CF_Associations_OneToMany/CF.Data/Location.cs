using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace CF.Data
{
    public class Location
    {
        public Location()
        {
            Attendees = new HashSet<Attendee>();
        }
        public int LocationID { get; set; }

        [MaxLength(20)]
        public string LocationName { get; set; }

        public virtual ICollection<Attendee> Attendees { get; set; }
    }
}
