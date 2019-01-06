using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            var dictionary = new MyDictionary<string, string>(5); //Создаем екземпляр класса MyDictionary зарытый типами string и string.

            dictionary.Add(0, "стол",      "table"); //Вызываем метод добавление пары ключь-значение в коллекцию словарь
            dictionary.Add(1, "яблоко",    "aplle");
            dictionary.Add(2, "карандаш",  "pencil");
            dictionary.Add(3, "солнце",    "sun");
            dictionary.Add(4, "блокнот",   "notepad");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item); //Отображение содержимого с помощью индексатора
            }

            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Вторая запись в словаре:");
            Console.WriteLine(dictionary[1]); //Поиск записи в словаре
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Размер словаря:");
            Console.WriteLine(dictionary.Lenght + " слов"); //Отображение длины словаря с помощью вызова метода Lenght который возвращает значение которое равно колличеству значений в словаре
            Console.WriteLine(new string('-', 50));

            // Delay.
            Console.ReadKey();
        }
    }
}
