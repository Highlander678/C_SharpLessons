using System;
using System.Linq;
using System.Data.Entity;
using CF.DataAccess;

namespace _002_CF_CreateDB
{
    class Program
    {
        static void Main()
        {
         //   Стратегии инициализации БД
            //Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<CodeContext>());
          // Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseAlways<CodeContext>());
           //Database.SetInitializer(new System.Data.Entity.CreateDatabaseIfNotExists<CodeContext>());

           ////Используется CodeFirst Migrations
           Database.SetInitializer(new System.Data.Entity.MigrateDatabaseToLatestVersion<CodeContext, CF.DataAccess.Migrations.Configuration>()); 

            using (var ctx = new CodeContext())
            {
                var attendees = ctx.Attendees.ToList();
                Console.WriteLine(attendees.Count());
            }
            Console.ReadKey();
        }
    }
}
