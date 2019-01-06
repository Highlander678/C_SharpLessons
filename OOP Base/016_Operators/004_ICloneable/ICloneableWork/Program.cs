using System;

namespace ICloneableWork
{
    class Program
    {
        static void Main()
        {
            Point original = new Point(100, 100);
            Point clone = original.Clone() as Point;

            Console.WriteLine("Первая проверка");

            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Изменяем clone.x (при этом original.x не изменится)
            clone.x = 0;

            // Проверка.
            Console.WriteLine("Вторая проверка после изменения");
            Console.WriteLine(original);
            Console.WriteLine(clone);

            // Delay.
            Console.ReadKey();
        }
    }
}
