﻿// Программа создает словарь данных типа Dictionary и записывает в этот
// словарь названия месяцев и количество дней в каждом месяце. Ключом
// словаря является название месяца, а значением - количество дней.
// Используя цикл foreach, программа выводит на консоль только те месяцы,
// количество дней в которых, равно 30
using System;
using System.Collections.Generic;
// Другие директивы using удалены, поскольку они не используются в данной
// программе.
namespace Месяцы
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем цвет текста на консоли для большей выразительности:
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Использование словаря данных";
            // Создаем словарь данных с полями типа String и int:
            var Месяцы = new Dictionary<String, int>();
            // Инициализировать словарь месяцев можно так:
            //  Месяцы["Январь"] = 31;    Месяцы["Июль"] = 31;
            //  Месяцы["Февраль"] = 29;   Месяцы["Август"] = 31;
            //  Месяцы["Март"] = 31;      Месяцы["Сентябрь"] = 30;
            //  Месяцы["Апрель"] = 30;    Месяцы["Октябрь"] = 31;
            //  Месяцы["Май"] = 31;       Месяцы["Ноябрь"] = 30;
            // можно так:
            //  Месяцы.Add("Июнь", 30);   Месяцы.Add("Декабрь", 31);
            // А МОЖНО БОЛЕЕ ИНТЕРЕСНО:
            //  Инициализация словаря месяцев
            for (int i = 0; i <= 11; i++)
                Месяцы.Add(
                    System.Globalization.CultureInfo.CurrentUICulture.
                    DateTimeFormat.MonthNames[i],
                    DateTime.DaysInMonth(2012, i+1));
            
            Console.WriteLine("Месяцы с 30 днями: ");
            Console.WriteLine();
            // Поиск в словаре месяцев, содержащих 30 дней:
            foreach (KeyValuePair<String, int> Месяц in Месяцы)
                if (Месяц.Value == 30)
                    Console.WriteLine("{0} - {1} дней",
                                      Месяц.Key, Месяц.Value);

            // Ждем от пользователя нажатия какой-либо клавиши:
            Console.ReadKey();
        }
    }
}
