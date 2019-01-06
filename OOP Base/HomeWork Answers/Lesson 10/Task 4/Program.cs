using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите размерность массива:");
            int u = Convert.ToInt32(Console.ReadLine()); //Запись значения полученного от пользователя конвертированного в int 

            var list = new MyList<int>(u); // Создание экземпляра класса MyList и инициализация пользовательским конструктором в который передается в качестве аргумента количество записей

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(x, t.Next(100)); //Метод добавления новой записи в список
            }

            Console.WriteLine("Массив");
            int[] f = list.GetArray();   // использование расширяющего метода

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("{0} ", f[i]); //Отображение содержимого списка
            }

            Console.WriteLine();
            Console.WriteLine("Длинна массива: {0}", list.Lenght); //отображение длинны списка

            // Delay.
            Console.ReadKey();
        }
    }
}
