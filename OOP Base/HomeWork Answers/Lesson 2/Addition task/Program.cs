using System;

namespace Lessons_2
{
    class Program
    {
        static void Main()
        {
            //Создание екземпляра класса user класса User и инициализация конструктором по умолчанию.
            User user = new User();
            //Вывод даты создания объекта user.
            Console.WriteLine(user.date.ToString());
            //Вывод значения поля surname с помощью свойства Surname
            Console.WriteLine(user.Surname);

            //Присвоение значения поля Surname
            user.Surname = "Evans";
            Console.WriteLine(user.Surname);

            //Отрисовка на консоли рядка из 30 символов '-'.
            Console.WriteLine(new string('-', 30));

            //Создание екземпляра класса user2 класса User
            User user2 = new User("naya", "Ann", "Kolesnik", 20);
            Console.WriteLine(user2.date.ToString());
            Console.WriteLine(user2.Surname);

            Console.ReadKey();
        }
    }
}
