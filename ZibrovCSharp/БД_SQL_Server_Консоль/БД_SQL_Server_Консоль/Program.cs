// Программа читает все записи из таблицы БД SQL Server (файл *.sdf) и
// выводит их на консоль с помощью объектов Command и DataReader
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Добавим в наш проект объектную библиотеку System.Data.SqlServerCe.dll,
// для этого выберем пункты меню: Project | Add Reference и в появившемся
// списке выберем ссылку System.Data.SqlServerCe
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
namespace БД_SQL_Server_Консоль
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса Connection:
            var Подключение =
                           new System.Data.SqlServerCe.SqlCeConnection();
            Подключение.ConnectionString =
                                 "Data Source=\"D:\\БД_SQL_Server.sdf\"";
            Подключение.Open();
            // Создаем объект класса Command: передавая ему SQL-команду
            var Команда =
                       new System.Data.SqlServerCe.SqlCeCommand();
            Команда.Connection = Подключение;
            // Передаем объекту Command SQL-команду:
            Команда.CommandText = "Select * From [БД телефонов]";
            // ДРУГИЕ КОМАНДЫ:
            // Выбрать все записи и сортировать их по колонке "Имя":
            // Команда.CommandText = 
            //                "Select * From [БД телефонов] order by Имя";
            // Аналогично по колонке "Номер телефона":
            // Команда.CommandText =
            //   "Select * From [БД телефонов] ORDER BY [Номер телефона]";
            // Выполняем SQL-команду и закрываем подключение:
            var Читатель = Команда.
               ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            // Задаем строку заголовка консоли:
            Console.Title = "Таблица БД:";
            Console.BackgroundColor = ConsoleColor.Cyan;  // - цвет фона
            Console.ForegroundColor = ConsoleColor.Black; // - цвет текста
            Console.Clear();
            // Выводим имена полей (колонок) таблицы:
            Console.WriteLine("{0,-11} {1,-11} {2,-15}" + "\n",
                               Читатель.GetName(0), Читатель.GetName(1), 
                               Читатель.GetName(2));
            while (Читатель.Read() == true)
            {
                // Цикл, пока не будут прочитаны все записи.
                // Читатель.FieldCount - кол-во полей в строке.
                // Здесь три поля: 0, 1 и 2.
                // Минус прижимает строку влево:
                Console.WriteLine("{0,-11} {1,-11} {2,-15}",
                Читатель.GetValue(0),
                Читатель.GetValue(1), Читатель.GetValue(2));
            }
            Читатель.Close(); Подключение.Close();
            // Приостановить выполнение программы до нажатия
            // какой-нибудь клавиши:
            Console.ReadKey();
        }
    }
}
