using System;

namespace Task_2
{
    class Program
    {
        static void Main() //Точка входа приложения
        {
            Console.WriteLine("Введите размерность массива:");
            string str = Console.ReadLine(); //Считывание значения полученного от пользователя и запись в переменную str
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str); //Тернарный оператор проверяет строку str пустая ли она, если пустая записать в переменную u, а если нет - записать значение переменной str конвертированое в int

            var list = new MyList<int>(); //Создание переменной и присвоение ей ссылки на экземпляр объекта MyList закрытый типом int

            var t = new Random(); //Создание нового экземпляра объекта Random
            for (int x = 0; x < u; x++)
            {
                list.Add(t.Next(100)); //Обавление нового элемента с помощью метода Add
            }

            Console.WriteLine("Массив элементов:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " "); //Отображение элементов содержащихся в объекте класса MyList
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Введите значение для поиска:");
            if (list.Contains(Convert.ToInt32(Console.ReadLine()))) //Вызываем метод поиска и передаем в него значение полученое от пользовалется конвертированное в Int
            {
                Console.WriteLine("Введенное значение содержится в массиве");
            }
            else
            {
                Console.WriteLine("Значение не найдено!");
            }

            //Delay
            Console.ReadKey();

        }
    }
}
