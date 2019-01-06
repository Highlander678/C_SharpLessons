using System;

namespace Lessons_5
{
    class Program
    {
        static void Main()
        {
            Dictionary dictionary = new Dictionary(); //Создание екземпляра класса Dictionary

            Console.WriteLine(dictionary["book"]); //Обращаемся к элементу как к масиву 
            Console.WriteLine(dictionary["дом"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стол"]);
            Console.WriteLine(dictionary["pen"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["солнце"]);

            Console.WriteLine(new string('-', 20)); //Отрисовка строки из 20 символов "-"

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]); //С помощью индексатора перебираем все элементы 
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
