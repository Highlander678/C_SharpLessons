using System;
using System.ComponentModel.DataAnnotations;

namespace CF.Data
{
    public class Attendee
    {
        [Key]
        public int AttendeKey { get; set; }
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
