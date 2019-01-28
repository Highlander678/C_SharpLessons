using System;
using System.Linq;
using System.Data.Entity;
using CF.DataAccess;

//ManyToMany
//Attendee может иметь много Sessions
//Sessions может иметь много Attendees
//Создаем свойства ICollection<T>
//В БД создается таблица SessionAttendees

namespace _005_CF_Associations
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new Init());
           
            using (var ctx = new CodeContext())
            {
              //  var query = ctx.Attendees.Select(c => c);

                var attendee = ctx.Attendees.First();

                Console.WriteLine(attendee);
                Console.WriteLine("\t" + attendee.Location);
                Console.WriteLine("\t" + attendee.Sessions.First());

            }
            Console.ReadKey();
        }
    }
}
