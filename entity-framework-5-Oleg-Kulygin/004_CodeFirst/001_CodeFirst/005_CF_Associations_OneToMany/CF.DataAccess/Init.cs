using System;
using System.Data.Entity;
using CF.Data;

namespace CF.DataAccess
{
    public class Init : DropCreateDatabaseIfModelChanges<CodeContext>
    {
        protected override void Seed(CodeContext context)
        {
            base.Seed(context);

            var office806 = new Location { LocationName = "Office806" };
            context.Attendees.Add(new Attendee
            {
                DateAdded = DateTime.UtcNow,
                LastName = "Ivanov",
                Location = office806
            });
            context.Attendees.Add(new Attendee
            {
                DateAdded = DateTime.UtcNow,
                LastName = "Petrov",
                Location = office806
            });
            context.SaveChanges();
        }
    }
}
