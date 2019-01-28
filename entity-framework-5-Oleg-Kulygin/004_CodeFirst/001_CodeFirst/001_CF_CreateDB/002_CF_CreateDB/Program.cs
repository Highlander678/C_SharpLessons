using CF.DataAccess;
using System;
using System.Linq;

//Данный пример создает БД с одной таблицей Attendee.
//Но не пересоздает ее, когда мы меняем структуру таблицы.
//В случае, если мы будем изменять тип поля, или добавлять еще одну таблицу - 
//программа нам выдаст ошибку. Чтобы этого избежать нужно удалить старую БД и запустить программу.

namespace _002_CF_CreateDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CodeContext("dbContext1"))
            {
                var attendees = ctx.Attendees.ToList();
                Console.WriteLine(attendees.Count());
            }
            Console.ReadKey();
        }
    }
}
