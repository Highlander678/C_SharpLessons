using System;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность словаря:");
            int n = Convert.ToInt32(Console.ReadLine()); //Запись значения полученного от пользователя конвертированного в Int

            var dictionary = new MyDictionary<string, string>(n); //Создание переменной типа MyDictionary и закрытие типами string

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "стол", "table"); //Вызов метода добавления новой записи в словарь
            }

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]); //Отображение значений словаря
            }

            Console.WriteLine(dictionary[1]); //Отображение определенной записи словаря по указанному ключу
            Console.WriteLine(dictionary.Lenght);

            // Delay.
            Console.ReadKey();
        }
    }
}
