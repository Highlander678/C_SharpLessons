using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            MyArrayList m = new MyArrayList(); //Создание переменной типа MyArrayList

            m.Add(5); //Добавление записей в коллекцию
            m.Add("Hello");
            m.Add('d');
            m.Add(5.78);

            Console.WriteLine("Массив:");
            Console.WriteLine(m.ToString()); //Отображение значений коллекции

            // Delay.
            Console.ReadKey();
        }
    }
}
