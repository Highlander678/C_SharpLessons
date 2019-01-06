using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate date1 = new MyDate(DateTime.Now); //Создание экземпляра класса MyDate
            Console.WriteLine(date1.ToString()); //Отображение содержимого date1

            MyDate date2 = new MyDate(new DateTime(2012, 12, 4));
            Console.WriteLine(date2.ToString());

            Console.WriteLine(MyDate.Sub(date1, date2).ToString());//Вызов метода вычитания дат и отображение результата
            Console.WriteLine(MyDate.Add(date1, date2).ToString());//Вызов метода сложения дат и отображение результата

            // Delay.
            Console.ReadKey();
        }
    }
}
