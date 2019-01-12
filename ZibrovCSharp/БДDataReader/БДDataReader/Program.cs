// Программа читает все записи из таблицы БД MS Access и выводит их
// на консоль с помощью объектов Command и DataReader
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// Добавляем эту директиву для краткости выражений:
using System.Data.OleDb;
namespace БДDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем цвет текста на консоли для большей выразительности:
            Console.ForegroundColor = ConsoleColor.White;
            // Создаем объект класса Connection
            var Подключение = new OleDbConnection();
            // Передаем ему строку подключения:
            Подключение.ConnectionString = 
                        "Data Source=\"D:\\vic.mdb\";User " +
                        "ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";";
            Подключение.Open();
            // Создаем объект класса Command:
            var Команда = new OleDbCommand();
            Команда.Connection = Подключение;
            // Передаем ему SQL-команду:
            Команда.CommandText = "Select * From [БД телефонов]";
            // Выбрать все записи и сортировать их по колонке "ФИО":
            // Команда.CommandText = 
            //                "Select * From [БД телефонов] order by ФИО";
            // Аналогично по колонке "Номер п/п":
            // Команда.CommandText =
            //        "Select * From [БД телефонов] ORDER BY [Номер п/п]";
            // или    "Select * From [БД телефонов] ORDER BY 'Номер п/п'";
            // Выполняем SQL-команду:
            var Читатель = Команда.ExecuteReader(
                             System.Data.CommandBehavior.CloseConnection);
            Console.WriteLine("Таблица БД:" + "\n");
            while (Читатель.Read() == true)
            {
                // Цикл, пока не будут прочитаны все записи.
                // Читатель.FieldCount - количество полей в строке.
                // Здесь три поля: 0, 1 и 2.
                // Минус прижимает строку влево:
                Console.WriteLine("{0,-3} {1,-15} {2,-15}", 
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
