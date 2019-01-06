using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число клиентов:");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            // Использование цикла с постусловием
            do
            {
                //Подсчет количества вариантов доставки
                result *= x--;
            } while (x > 0); //Постусловие

            Console.WriteLine("Количество вариантов доставки: {0}", result);

            // Delay.
            Console.ReadKey();
        }
    }
}
