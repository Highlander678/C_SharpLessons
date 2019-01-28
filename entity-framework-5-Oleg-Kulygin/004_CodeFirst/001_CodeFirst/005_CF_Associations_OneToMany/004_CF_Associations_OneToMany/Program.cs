using System;
using System.Linq;
using System.Data.Entity;
using CF.DataAccess;

//Свойства полей, тип, длина, null/not null...

namespace _004_CF_Associations
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new Init());

            using (var ctx = new CodeContext())
            {
                foreach (var attendee in ctx.Attendees)
                {
                    Console.WriteLine("Attendee:{1},Added:{2}, Location:{3}",attendee.AttendeeID,attendee.LastName,attendee.DateAdded,attendee.Location.LocationName);
                }

                var location = ctx.Locations.FirstOrDefault();
                if (location != null)
                {
                    foreach (var attendee in location.Attendees)
                    {
                        Console.WriteLine("Attendee:{1},Added:{2}, Location:{3}", attendee.AttendeeID, attendee.LastName, attendee.DateAdded, attendee.Location.LocationName);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
