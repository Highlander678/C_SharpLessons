using System;
using System.ComponentModel.DataAnnotations;

namespace CF.Data
{
    public class Attendee
    {
        public int AttendeeID { get; set; }

        [Required, MaxLength(100)]
        public string LastName { get; set; }

        public DateTime? DateAdded { get; set; }

        //Создаем вторичный ключ и связываем таблицы один ко многим
        //Обратите внимание на Virtual ->Lazy Load !!!
        [Required]
        public virtual Location Location { get; set; }
    }
}
