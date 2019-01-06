using System;
using System.Threading;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 40); //Устанавливаем размеры окна консоли

            Matrix instance; //Создание экземпляра класса Matrix
            
            for (int i = 0; i < 30; i++)
            {
                instance = new Matrix(i * 2); //инициализиция пользовательским конструкторм
                new Thread(instance.Move).Start();//Запускаем метод Move экземпляра класса instance в отдельном потоке
            }

            Console.ReadKey();
        }
    }
}
