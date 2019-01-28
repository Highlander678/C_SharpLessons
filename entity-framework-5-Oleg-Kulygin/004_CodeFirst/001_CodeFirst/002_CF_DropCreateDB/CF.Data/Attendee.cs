using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CF.Data
{
    [Table("AttendeesList", Schema = "Education")]
    public class Attendee
    {
        [Key]
        public int AttendeeID { get; set; }

        [Required, MaxLength(50)]           //Not null
        public string LastName { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [Column("Created", TypeName = "datetime2")]
        public DateTime? DateAdded { get; set; }
    }
}
