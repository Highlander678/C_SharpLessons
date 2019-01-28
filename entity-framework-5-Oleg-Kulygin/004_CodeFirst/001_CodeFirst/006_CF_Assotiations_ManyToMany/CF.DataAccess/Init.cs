using System.Data.Entity;
using CF.Data;

//Переопределяя метод Seed мы можем добавлять записи в созданные таблицы.

namespace CF.DataAccess
{
    public class Init : DropCreateDatabaseIfModelChanges<CodeContext>
    {
        protected override void Seed(CodeContext context)
        {
            base.Seed(context);

            var location = new Location {LocationName = "Kyiv, CBS"};

            var session = new Session {SessionName = "EF 5.0"};

            var attendee = new Attendee()
                               {
                                   FirstName = "Alex",
                                   LastName = "Smirnov",
                                   Location = location,
                               };

            attendee.Sessions.Add(session);

            context.Attendees.Add(attendee);
            context.SaveChanges();
        }
    }
}
