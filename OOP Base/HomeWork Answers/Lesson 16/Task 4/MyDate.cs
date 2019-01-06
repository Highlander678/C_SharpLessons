using System;

namespace Task_4
{
    class MyDate
    {
        readonly DateTime date; //Создание экземпляра класса DateTime доступным только для чтения

        public MyDate(DateTime date) //Пользовательский конструктор
        {
            this.date = date;
        }

        public static MyDate operator -(MyDate date1, MyDate date2) //Перегрузка оператора вычитания
        {
            TimeSpan timeSpan = date1.date - date2.date;
            DateTime newDate = date1.date.AddDays(timeSpan.Days);
            return new MyDate(newDate);
        }

        public static MyDate operator +(MyDate date1, MyDate date2)//Перегрузка оператора сложения 
        {
            TimeSpan timeSpan = date1.date - date2.date;
            DateTime newDate = date1.date.AddDays(-timeSpan.Days);
            return new MyDate(newDate);
        }

        public static MyDate Sub(MyDate d1, MyDate d2) //Метод вычитания дат
        {
            return d1 - d2;
        }

        public static MyDate Add(MyDate d1, MyDate d2) //Метод сложения дат
        {
            return d1 + d2;
        }

        public override string ToString() //Переопределение метода ToString
        {
            return "Дата: " + date;
        }
    }
}
