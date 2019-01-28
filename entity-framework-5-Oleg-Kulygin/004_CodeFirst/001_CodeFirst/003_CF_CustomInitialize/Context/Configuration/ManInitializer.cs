using System.Data.Entity;

namespace _007_CodeFirst
{
    public class ManInitializer : IDatabaseInitializer<ManContext>
    {
        public void InitializeDatabase(ManContext context)
        {
            if (context.Database.Exists())
                context.Database.Delete();
            context.Database.Create();

            context.Men.Add(new Man { ManID = 1, Name = "Alex" });
            context.Men.Add(new Man { ManID = 2, Name = "Dima" });
            context.Men.Add(new Man { ManID = 3, Name = "Aleksey" });

            context.SaveChanges();
        }
    }
}