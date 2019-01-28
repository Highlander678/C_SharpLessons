using System;
using System.Linq;

namespace Model_First
{
    class Program
    {
        static void Main()
        {
            var db = new UsersContainer();

            var department1 = new Department()
            {
                Name = "MainOffice"
            };
            var alex = new User()
            {
                FirstName = "Alex", LastName = "Ivanov", Email = "user@site.com",
                Department = department1
            };
            var superAdmin = new Admin()
            {
                FirstName = "SuperAdmin", LastName = "Adminov", Email = "admin@site.com",
                Level = 111,
                Department = department1
            };

            db.Users.Add(alex);
            db.Users.Add(superAdmin);
            db.SaveChanges();

            foreach (var item in db.Users)
            {
                Console.WriteLine(item.GetType());
            }
            Console.WriteLine(new string('-', 20));

            var admin = db.Users.OfType<Admin>().First();

            Console.WriteLine(admin.FirstName + ", level:" + admin.Level);

            foreach (var department in db.Departments)
            {
                Console.WriteLine(department.Name);
                foreach (var user in department.Users)
                {
                    Console.WriteLine("\t"+user.FirstName);
                }
            }

        }
    }
}
