using System;

namespace CF.Data
{
    public class Location
    {
        public int LocationID { get; set; }
        public string LocationName { get; set; }

        public override string ToString()
        {
            return String.Format("Location-ID:{0}, Name:{1}",LocationID,LocationName);
        }
    }
}
