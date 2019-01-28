using System;
using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class DropCreateAttendeeDB : DropCreateDatabaseIfModelChanges<CodeContext>
    {
        protected override void Seed(CodeContext context)
        {
            base.Seed(context);

            context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Ivanov" });
            context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Petrov" });
            context.Attendees.Add(new Attendee { DateAdded = DateTime.UtcNow, LastName = "Sidorov" });

            context.SaveChanges();
        }
    }
}
