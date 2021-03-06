﻿// Программа добавляет запись в таблицу базы данных MS Access. Для этого
// при создании экземпляра объекта Command задаем SQL-запрос
// на вставку (Insert) новой записи в таблицу базы данных
using System;
// Другие директивы using удалены, поскольку они не используются в данной
// программе
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Добавляем эту директиву для более краткого обращения к классам
// обработки данных:
using System.Data.OleDb;
// ~ ~ ~ ~ ~ ~ ~ ~ 
// Для вызова MessageBox выберем следующие пункты меню:
// Project | Add Reference | Accemblies | Framework, затем в списке ссылок
// выберем ссылку System.Windows.Forms, а в тексте программы добавим
// директиву:
using System.Windows.Forms;

namespace БдДобавлЗаписи
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДОБАВЛЕНИЕ ЗАПИСИ В ТАБЛИЦУ БД:
            // Создание экземпляра объекта Connection
            // с указанием строки подключения:
            var Подключение = new OleDbConnection(
           "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\new_BD.mdb");
            // Открытие подключения:
            Подключение.Open();
            // Создание экземпляра объекта Command с заданием SQL-запроса:
            var Команда = new OleDbCommand(
                "INSERT INTO [бд телефонов] (" +
                "Фио, [номер телефона]) VALUES ('Света-X', '521-61-41')");
            //  "Фио, [номер телефона]) VALUES ('Vitia', '523-23-18')");
            // Для добавления записи в таблицу БД эта команда обязательна:
            Команда.Connection = Подключение;
            // Выполнение команды SQL:
            Команда.ExecuteNonQuery();
            MessageBox.Show("В таблицу 'БД телефонов' добавлена запись");
            Подключение.Close();
        }
    }
}
