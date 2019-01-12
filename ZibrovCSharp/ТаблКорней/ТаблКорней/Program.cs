using System;
// Консольное приложение задает цвета и заголовок консоли, а затем выводит
// таблицу извлечения квадратного корня от нуля до десяти
namespace ТаблКорней
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Таблица"; Console.Clear();
            Console.WriteLine("Число  Корень");
            for (Double i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0,4} {1,8:F4}", i, Math.Sqrt(i));
            }
            Console.ReadKey();
        }
    }
}
