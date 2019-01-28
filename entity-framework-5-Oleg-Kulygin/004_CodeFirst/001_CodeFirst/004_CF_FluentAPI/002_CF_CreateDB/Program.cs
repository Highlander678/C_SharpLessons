using System;
using System.Linq;
using System.Data.Entity;
using CF.DataAccess;

//Использование Fluent API для настройки таблицы.
namespace _002_CF_CreateDB
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new DropCreateAttendeeDB());
            
            using (var ctx = new CodeContext())
            {
                var attendeesQuery = ctx.Attendees.Select(c => c);
                Console.WriteLine(attendeesQuery.Count());

                Console.WriteLine(attendeesQuery);
            }

            Console.ReadKey();
        }
    }
}
