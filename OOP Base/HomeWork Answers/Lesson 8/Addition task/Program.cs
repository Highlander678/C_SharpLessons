using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons_8
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now; //Представляет текущее время
            DateTime birthday;
            TimeSpan wait; //Представляет промежуток времени

            Console.WriteLine("Введите дату вашего рождения в формате 'гггг, мм, дд'");
            birthday = Convert.ToDateTime(Console.ReadLine()); //Запись в поле birthday значением полученым от пользователя конвертированым в DateTime


            DateTime thisYear = new DateTime(now.Year, birthday.Month, birthday.Day); //Создание переменной типа DateTime и запись значений текущего года, месяца и дня рождения

            if (thisYear < now)//Если значение поля thisYear меньше значения поля now
            {
                thisYear = new DateTime(now.Year + 1, birthday.Month, birthday.Day); //К полю now.Year добавляем единицу
                wait = thisYear - now; //Узнаем промежуток времени до дня рождения
            }
            else
            {
                wait = thisYear - now;
            }   

            Console.WriteLine("До дня рождения осталось {0} дней", wait.Days); //Отображаем полученый результат

            // Delay.
            Console.ReadKey();
        }
    }
}