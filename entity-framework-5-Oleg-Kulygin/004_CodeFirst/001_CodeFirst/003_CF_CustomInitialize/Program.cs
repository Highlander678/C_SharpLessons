using System;
using System.Data.Entity;

namespace _007_CodeFirst
{
    class Program
    {
        static void Main()
        {
            Database.SetInitializer(new ManInitializer());

            var db = new ManContext();
            db.Database.Initialize(false);

            Console.WriteLine("Complete");

            Console.ReadLine();
        }
    }
}
