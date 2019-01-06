using System;
using System.Threading;

namespace Lessons_13
{
    class Program
    {
        static int deep; //Статическое целочисленное поле

        static public void Recursion()//Рекурсивный метод
        {
            // Thread.CurrentThread.Name 
            Console.WriteLine("{0}  say  \"Hello!\"", Thread.CurrentThread.Name);
            Thread.Sleep(1000); //Остонавливаем поток на 1 секунду
            Thread thread = new Thread(Recursion); //Создаем повый поток
            deep++; //Инкрементируем переменную deep
            thread.Name = "Thread " + deep; //Полю Name объекта thread призваниваем строковое значение
            thread.Start(); //Запускаем поток


        }

        static void Main()
        {
            Thread thread = new Thread(Recursion) //Создание экземпляра класса Thread
            {
                Name = "Thread " + deep
            }; //Блок инициализатора
            thread.Start();
        }
    }
}
