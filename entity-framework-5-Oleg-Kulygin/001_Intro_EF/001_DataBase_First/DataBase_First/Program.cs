using System;

namespace DataBase_First
{
    class Program
    {
        static void Main()
        {
            var context = new PersonEntities();

            foreach (var person in context.People)
            {
                Console.WriteLine("{0}: {1,-6} - {2} years",person.Id,person.Name,person.Age);
            }
        }
    }
}