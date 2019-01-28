using System;
using System.Collections.Generic;

namespace CF.Data
{
    public class Attendee
    {
        public Attendee()
        {
            Sessions = new HashSet<Session>();
        }

        public int AttendeeID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateAdded { get; set; }

        public virtual Location Location { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

        public override string ToString()
        {
            return String.Format("Attendee-ID:{0}, Name:{1} {2}", AttendeeID, FirstName, LastName);
        }
    }
}
