using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            MyList<int> list = new MyList<int>(); //Создание параметризированной коллекции MyList с типом int
            for (int i = 0; i < 5; i++)
                list.Add(i); //Добавляем элементы в коллекцию

            Console.WriteLine("Длина массива = {0}", list.Count); //Отображаем длинну коллекции

            foreach (int item in list)
                Console.Write("{0}  ", item); //Отображаем содержимое коллекции

            // Delay.
            Console.ReadKey();
        }
    }
}
