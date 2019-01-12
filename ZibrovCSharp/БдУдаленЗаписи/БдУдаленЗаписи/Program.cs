// Программа удаляет запись из таблицы БД с использованием SQL-запроса
// и объекта класса Command
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для вызова MessageBox добавим в наш проект также укажем пункты меню:
// Project | Add Reference | Assemblies | Framework дважды щелкнем на ссылке
// System.Windows.Forms, а в тексте программы добавим директиву:
using System.Windows.Forms;
namespace БдУдаленЗаписи
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект Connection и передаем ему строку подключения
            var Подключение = new System.Data.OleDb.
                       OleDbConnection(
                          "Data Source=\"D:\\vic.mdb\";User " +
                          "ID=Admin;Provider=\"Microsoft.Jet.OLEDB.4.0\";");
            Подключение.Open();
            // Создаем объект класса Command, передавая ему SQL-команду
            var Команда = new System.Data.OleDb.
                          OleDbCommand(
                         "Delete * From [БД телефонов] Where " +
                         "ФИО Like 'Vi%'", Подключение);
            // Выполнение команды SQL
            var i = Команда.ExecuteNonQuery();
            // i - количество удаленных записей
            if (i > 0) MessageBox.Show(
               "Записи, содержащие в поле ФИО фрагмент 'Vi*', удалены");
            if (i == 0) MessageBox.Show(
               "Запись, содержащая в поле ФИО фрагмент 'Vi*', не найдена");
            Подключение.Close();
        }
    }
}
