using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CF.Data
{
    public class Session
    {
        public Session()
        {
            Attendees = new HashSet<Attendee>();
        }

        public int SessionID { get; set; }
        public string SessionName { get; set; }
        
        public virtual ICollection<Attendee> Attendees { get; set; }

        public override string ToString()
        {
            return String.Format("Session-ID:{0}, Name:{1}", SessionID, SessionName);
        }
    }
}
